using Authing.CSharp.SDK.Models.Authentication;
using Authing.CSharp.SDK.Utils;
using Authing.CSharp.SDK.UtilsImpl;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Authing.CSharp.SDK.IServices;
using Jose;
using Newtonsoft.Json;
using Authing.CSharp.SDK.Models;

namespace Authing.CSharp.SDK.Services
{
    /// <summary>
    /// 认证
    /// </summary>
    public partial class AuthenticationClient : BaseAuthenticationService
    {
        private const string DEFAULT_COOKIE_KEY = "X-Authing-Node-OIDC-State";
        private const string DEFAULT_SCOPE = "openid profile";

        private readonly AuthenticationClientInitOptions options;
        private readonly string domain;
        private JwkSet serverJwks;

        private IRegexService regexService = new RegexService();
        private IJsonService jsonService = new JsonService();
        private IStringService stringService = new StringService();
        private IEncryptService encryptService = new EncryptService();

        public string AccessToken { get; private set; }
        public string IdToken { get; private set; }
        public string ExpireTime { get; private set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="options"></param>
        public AuthenticationClient(AuthenticationClientInitOptions options)
            : base(options)
        {
            if (string.IsNullOrWhiteSpace(options.CookieKey))
            {
                options.CookieKey = DEFAULT_COOKIE_KEY;
            }
            if (string.IsNullOrWhiteSpace(options.Scope))
            {
                options.Scope = DEFAULT_SCOPE;
            }

            if (!options.Scope.Contains("openid"))
            {
                throw new Exception("scope 中必须包含 openid");
            }

            this.options = options;
            this.domain = regexService.DomainC14n(options.AppHost);

        }

        private async Task<JwkSet> GetJwksFromServer()
        {
            if (options.ServerJWKS != null)
            {
                this.serverJwks = options.ServerJWKS;
            }
            else
            {
                try
                {
                    this.serverJwks = await GetJWKSJSONAsync();
                }
                catch (Exception exp)
                {
                    throw new Exception("自动获取认证服务器 JWKS 公钥失败, 请检查域名是否正确, 或手动指定 serverJWKS 参数:" + exp.Message);
                }
            }

            return serverJwks;
        }

#if NET45

        /// <summary>
        /// 将用户浏览器重定向到 Authing 的认证发起 URL 进行认证，利用 Cookie 将上下文信息传递到应用回调端点
        /// </summary>
        /// <param name="httpResponse">应用侧向 Authing 请求的权限，覆盖初始化参数中的对应设置</param>
        /// <param name="scope">应用侧向 Authing 请求的权限，覆盖初始化参数中的对应设置</param>
        /// <param name="state">中间状态标识符，默认自动生成</param>
        /// <param name="nonce">出现在 ID Token 中的随机字符串，默认自动生成</param>
        /// <param name="redirectUri">回调地址，覆盖初始化参数中的对应设置</param>
        /// <param name="forced">即便用户已经登录也强制显示登录页</param>
        public void LoginWithRedirect(System.Web.HttpResponse httpResponse, string scope, string state = null, string nonce = null, string redirectUri = null,
            bool forced = false)
        {
            AuthUrlResult authUrlResult = BuildAuthUrl(scope, state, nonce, redirectUri, forced);
            httpResponse.Headers.Set("Location", authUrlResult.Url);

            LoginTransaction loginTransaction = new LoginTransaction
            {
                State = string.IsNullOrWhiteSpace(state) ? authUrlResult.State : state,
                Nonce = string.IsNullOrWhiteSpace(nonce) ? authUrlResult.Nonce : nonce,
                RedirectUri = string.IsNullOrWhiteSpace(redirectUri) ? options.RedirectUri : redirectUri
            };

            string base64Str = stringService.B64Encode(jsonService.SerializeObject(loginTransaction));

            httpResponse.Headers.Set("Set-Cookie",
                $"{options.CookieKey}={base64Str}; HttpOnly; SameSite=Lax");

            httpResponse.StatusCode = 302;
        }

        /// <summary>
        /// 在应用回调端点处理认证返回结果，利用 Cookie 中传递的上下文信息进行安全验证，并获取用户登录态
        /// </summary>
        /// <param name="request">http 请求对象，用于获取认证结果和上下文 Cookie</param>
        /// <param name="response">http 响应对象，只用于清除上下文 Cookie</param>
        /// <returns></returns>
        public async Task<LoginState> HandleRedirectCallback(System.Web.HttpRequest request, System.Web.HttpResponse response)
        {
            if (string.IsNullOrWhiteSpace(request.Url.AbsoluteUri))
            {
                throw new Exception("req 对象没有 url");
            }

            string error = request.Params["error"];

            if (!string.IsNullOrWhiteSpace(error))
            {
                throw new Exception($"认证服务器返回错误:error:error_description");
            }

            string code = request.Params["code"];
            if (string.IsNullOrWhiteSpace(code))
            {
                throw new Exception("认证服务器未返回授权码");
            }

            string cookieKey = $"{this.options.CookieKey}=";
            string txStr = request.Headers["Cookie"].Split(';').First(p => p.StartsWith(cookieKey)).Substring(cookieKey.Length);
            if (string.IsNullOrWhiteSpace(txStr))
            {
                throw new Exception("Cookie 中没有中间态，认证失败");
            }

            LoginTransaction tx = jsonService.DeserializeObject<LoginTransaction>(stringService.B64Decode(txStr));

            response.Headers.Set("Set-Cookie", $"{cookieKey}; HttpOnly; SameSite=Lax; Max-Age=0");

            string state = request.Params["state"];
            if (state != tx.State)
            {
                throw new Exception("state 验证失败");
            }

            LoginState loginState = await GetLoginStateByAuthCode(code, tx.RedirectUri).ConfigureAwait(false);
            if (loginState.ParsedIDToken.Nonce != tx.Nonce)
            {
                throw new Exception("nonce 校验失败");
            }

            return loginState;
        }

#endif

#if NETCOREAPP

        /// <summary>
        /// 将用户浏览器重定向到 Authing 的认证发起 URL 进行认证，利用 Cookie 将上下文信息传递到应用回调端点
        /// </summary>
        /// <param name="httpResponse">应用侧向 Authing 请求的权限，覆盖初始化参数中的对应设置</param>
        /// <param name="scope">应用侧向 Authing 请求的权限，覆盖初始化参数中的对应设置</param>
        /// <param name="state">中间状态标识符，默认自动生成</param>
        /// <param name="nonce">出现在 ID Token 中的随机字符串，默认自动生成</param>
        /// <param name="redirectUri">回调地址，覆盖初始化参数中的对应设置</param>
        /// <param name="forced">即便用户已经登录也强制显示登录页</param>
        public void LoginWithRedirect(Microsoft.AspNetCore.Http.HttpResponse httpResponse, string scope = null,
           string state = null, string nonce = null, string redirectUri = null,
           bool forced = false)
        {
            AuthUrlResult authUrlResult = BuildAuthUrl(scope, state, nonce, redirectUri, forced);

            if (!httpResponse.Headers.ContainsKey("Location"))
            {
                httpResponse.Headers.Add("Location", authUrlResult.Url);
            }

            LoginTransaction loginTransaction = new LoginTransaction
            {
                State = string.IsNullOrWhiteSpace(state) ? authUrlResult.State : state,
                Nonce = string.IsNullOrWhiteSpace(nonce) ? authUrlResult.Nonce : nonce,
                RedirectUri = string.IsNullOrWhiteSpace(redirectUri) ? options.RediretUri : redirectUri
            };

            string base64Str = stringService.B64Encode(jsonService.SerializeObject(loginTransaction));

            if (!httpResponse.Headers.ContainsKey("Set-Cookie"))
            {
                httpResponse.Headers.Add("Set-Cookie",
                    $"{options.CookieKey}={base64Str}; HttpOnly; SameSite=Lax");
            }

            httpResponse.StatusCode = 302;
        }

        /// <summary>
        /// 在应用回调端点处理认证返回结果，利用 Cookie 中传递的上下文信息进行安全验证，并获取用户登录态
        /// </summary>
        /// <param name="request">http 请求对象，用于获取认证结果和上下文 Cookie</param>
        /// <param name="response">http 响应对象，只用于清除上下文 Cookie</param>
        /// <returns></returns>
        public async Task<LoginState> HandleRedirectCallback(Microsoft.AspNetCore.Http.HttpRequest request, Microsoft.AspNetCore.Http.HttpResponse response)
        {
            if (string.IsNullOrWhiteSpace(request.QueryString.Value))
            {
                throw new Exception("req 对象没有 url");
            }

            string error = request.Query["error"];

            if (!string.IsNullOrWhiteSpace(error))
            {
                throw new Exception($"认证服务器返回错误:error:error_description");
            }

            string code = request.Query["code"];
            if (string.IsNullOrWhiteSpace(code))
            {
                throw new Exception("认证服务器未返回授权码");
            }

            string cookieKey = $"{this.options.CookieKey}=";
            string txStr = request.Headers["Cookie"].First().Split(';').First(p => p.StartsWith(cookieKey)).Substring(cookieKey.Length);
            if (string.IsNullOrWhiteSpace(txStr))
            {
                throw new Exception("Cookie 中没有中间态，认证失败");
            }

            LoginTransaction tx = jsonService.DeserializeObject<LoginTransaction>(stringService.B64Decode(txStr));

            if (!response.Headers.ContainsKey("Set-Cookie"))
            {
                response.Headers.Add("Set-Cookie", $"{cookieKey}; HttpOnly; SameSite=Lax; Max-Age=0");
            }
            else
            {
                response.Headers["Set-Cookie"] = $"{cookieKey}; HttpOnly; SameSite=Lax; Max-Age=0";
            }

            string state = request.Query["state"];
            if (state != tx.State)
            {
                throw new Exception("state 验证失败");
            }

            LoginState loginState = await GetLoginStateByAuthCode(code, tx.RedirectUri).ConfigureAwait(false);
            if (loginState.ParsedIDToken.Nonce != tx.Nonce)
            {
                throw new Exception("nonce 校验失败");
            }

            return loginState;
        }

        /// <summary>
        /// 将浏览器重定向到 Authing 的登出发起 URL 进行登出
        /// </summary>
        /// <param name="response">http 响应对象，用于进行重定向</param>
        /// <param name="idToken">用户登录时获取的 ID Token，用于无效化用户 Token，建议传入</param>
        /// <param name="redirectUri">登出完成后的重定向目标 URL，覆盖初始化参数中的对应设置</param>
        /// <param name="state">传递到目标 URL 的中间状态标识符</param>
        public void LogoutWithRedirect(Microsoft.AspNetCore.Http.HttpResponse response, string idToken = null, string redirectUri = null, string state = null)
        {
            response.Headers["Location"] = BuildLogoutUrl(idToken, redirectUri, state);
            response.StatusCode = 302;
        }

#endif

        /// <summary>
        /// 获取应用的公钥相关信息
        /// </summary>
        /// <returns></returns>
        public async Task<JwkSet> GetJWKSJSONAsync()
        {
            string json = await GetWithHostAsync(domain, "/oidc/.well-known/jwks.json").ConfigureAwait(false);

            var jwks = Jose.JwkSet.FromJson(json, Jose.JWT.DefaultSettings.JsonMapper);
            return jwks;
        }

        /// <summary>
        /// 生成认证发起 URL
        /// </summary>
        /// <param name="scope">本次认证中请求获得的权限，覆盖初始化参数中的对应设置</param>
        /// <param name="state">中间状态标识符，默认自动生成</param>
        /// <param name="nonce">出现在 ID Token 中的随机字符串，默认自动生成</param>
        /// <param name="redirectUri">回调地址，覆盖初始化参数中的对应设置</param>
        /// <param name="forced">即便用户已经登录也强制显示登录页</param>
        /// <returns></returns>
        public AuthUrlResult BuildAuthUrl(string scope = null, string state = null, string nonce = null, string redirectUri = null, bool forced = false)
        {
            if (string.IsNullOrWhiteSpace(state))
            {
                state = GenerateRandomString(16);
            }
            if (string.IsNullOrWhiteSpace(nonce))
            {
                nonce = GenerateRandomString(16);
            }
            if (string.IsNullOrWhiteSpace(scope))
            {
                scope = options.Scope;
            }

            AuthURLParams authURLParams = new AuthURLParams()
            {
                RedirectUri = string.IsNullOrWhiteSpace(redirectUri) ? this.options.RedirectUri : redirectUri,
                ResponseMode = "query",
                ResponseType = "code",
                ClientId = this.options.AppId,
                Scope = scope,
                State = state,
                Nonce = nonce
            };

            if (forced)
            {
                authURLParams.Propmpt = "login";
            }
            else if (scope.Split(' ').Contains("offline_access"))
            {
                authURLParams.Propmpt = "consent";
            }

            authURLParams.RedirectUri = UrlEncode(authURLParams.RedirectUri);

            AuthUrlResult authUrlResult = new AuthUrlResult()
            {
                Url = $"{this.domain}/oidc/auth?{CreateQueryParams(authURLParams)}",
                State = state,
                Nonce = nonce
            };

            return authUrlResult;
        }

        /// <summary>
        /// 用授权码获取用户登录态
        /// </summary>
        /// <param name="code">Authing 返回的授权码</param>
        /// <param name="redirectUri">发起认证时传入的回调地址</param>
        /// <returns></returns>
        public async Task<LoginState> GetLoginStateByAuthCode(string code, string redirectUri)
        {
            CodeToTokenParams tokenParam = new CodeToTokenParams
            {
                Code = code,
                ClientId = this.options.AppId,
                ClientSecret = this.options.AppSecret,
                RedirectUri = redirectUri,
                GrantType = "authorization_code"
            };

            OIDCTokenResponse response = await GetToken(tokenParam).ConfigureAwait(false);
            var result = await BuildLoginState(response);
            return result;
        }

        /// <summary>
        /// 用 Access Token 获取用户身份信息
        /// </summary>
        /// <param name="accessToken">Access Token</param>
        /// <returns></returns>
        public async Task<UserInfo> GetUserInfo(string accessToken)
        {
            string json = await GetAsync("/oidc/me", "", accessToken).ConfigureAwait(false);
            UserInfo info = jsonService.DeserializeObject<UserInfo>(json);
            return info;
        }

        /// <summary>
        /// 用 Refresh Token 刷新用户的登录态，延长过期时间
        /// 为了获取 Refresh Token，需要在 scope 参数中加入 offline_access
        /// </summary>
        /// <param name="refreshToken"></param>
        /// <returns></returns>
        public async Task<LoginState> RefreshLoginState(string refreshToken)
        {
            RefreshTokenParams param = new RefreshTokenParams()
            {
                ClientId = this.options.AppId,
                ClientSecret = this.options.AppSecret,
                RefreshToken = refreshToken,
                GrantType = "refresh_token"
            };

            string json = await PostFormAsync("/oidc/token", param).ConfigureAwait(false);
            OIDCTokenResponse res = jsonService.DeserializeObject<OIDCTokenResponse>(json);
            var result = await BuildLoginState(res);
            return result;
        }

        /// <summary>
        /// 生成登出 URL
        /// </summary>
        /// <param name="idToken">用户登录时获取的 ID Token，用于无效化用户 Token，建议传入</param>
        /// <param name="redirectUri">登出完成后的重定向目标 URL ,需要和控制台的登出回调 URL 一致，覆盖初始化参数中的对应设置,</param>
        /// <param name="state">传递到目标 URL 的中间状态标识符</param>
        /// <returns></returns>
        public string BuildLogoutUrl(string idToken = null, string redirectUri = null, string state = null)
        {
            if (string.IsNullOrWhiteSpace(redirectUri))
            {
                redirectUri = this.options.LogoutRedirectUri;
            }

            redirectUri = UrlEncode(redirectUri);

            LogoutURLParams logoutURLParams = new LogoutURLParams()
            {
                PostLogoutRedirectUri = redirectUri,
                State = state,
                IdTokenHint = idToken
            };

            return $"{this.domain}/oidc/session/end?{CreateQueryParams(logoutURLParams)}";
        }


        /// <summary>
        /// 验证并解析 ID Token
        /// </summary>
        /// <param name="token">ID Token</param>
        /// <returns></returns>
        public async Task<IDToken> ParseIDToken(string token, JwkSet jwks = null)
        {
            IDToken idToken = new IDToken();
            string jsonStr = "";
            try
            {
                if (jwks == null)
                {
                    jwks = await GetJwksFromServer();
                }

                IDictionary<string, object> dic = Jose.JWT.Headers(token);
                if (dic.ContainsKey("alg"))
                {
                    if (dic["alg"].ToString() == "RS256")
                    {
                        jsonStr = Jose.JWT.Decode(token, jwks.First(), Jose.JWT.DefaultSettings);
                    }
                    else
                    {
                        byte[] bytes = Encoding.UTF8.GetBytes(options.AppSecret);
                        jsonStr = Jose.JWT.Decode(token, bytes, Jose.JWT.DefaultSettings);
                    }
                }
            }
            catch (Exception)
            {

            }
            idToken = jsonService.DeserializeObject<IDToken>(jsonStr);
            return idToken;
        }

        /// <summary>
        /// 验证并解析 Access Token
        /// </summary>
        /// <param name="token"> Authing 颁发的 Access token</param>
        /// <returns></returns>
        public async Task<AccessToken> ParseAccessToken(string token, JwkSet jwks = null)
        {
            string jsonStr = "";
            try
            {
                if (jwks == null)
                {
                    jwks = await GetJwksFromServer();
                }

                jsonStr = Jose.JWT.Decode(token, jwks.First(), Jose.JWT.DefaultSettings);
            }
            catch (Exception)
            {
            }

            AccessToken accessToken = jsonService.DeserializeObject<AccessToken>(jsonStr);
            return accessToken;
        }

        /// <summary>
        /// 编码 Url
        /// </summary>
        /// <param name="ParaUrl"></param>
        /// <returns></returns>
        private string UrlEncode(string ParaUrl)
        {

            ParaUrl = ParaUrl.Replace("+", "%2B");

            ParaUrl = ParaUrl.Replace("~", "%7E");

            ParaUrl = ParaUrl.Replace("!", "%21");

            ParaUrl = ParaUrl.Replace("@", "%40");

            ParaUrl = ParaUrl.Replace("#", "%23");

            ParaUrl = ParaUrl.Replace("$", "%24");

            //ParaUrl = ParaUrl.Replace("%", "%25");

            ParaUrl = ParaUrl.Replace("^", "%5E");

            ParaUrl = ParaUrl.Replace("&", "%26");

            ParaUrl = ParaUrl.Replace("*", "%2A");

            ParaUrl = ParaUrl.Replace("(", "%28");

            ParaUrl = ParaUrl.Replace(")", "%29");

            ParaUrl = ParaUrl.Replace("_", "%5F");

            ParaUrl = ParaUrl.Replace("+", "%2B");

            ParaUrl = ParaUrl.Replace("=", "%3D");

            ParaUrl = ParaUrl.Replace("-", "%2D");

            ParaUrl = ParaUrl.Replace("\\", "%5C");

            ParaUrl = ParaUrl.Replace(">", "%3E");

            ParaUrl = ParaUrl.Replace("/", "%2F");

            ParaUrl = ParaUrl.Replace("?", "%3F");

            ParaUrl = ParaUrl.Replace(" ", "%20");

            ParaUrl = ParaUrl.Replace("*", "%2A");

            ParaUrl = ParaUrl.Replace(".", "%2E");

            ParaUrl = ParaUrl.Replace("*", "%2A");

            ParaUrl = ParaUrl.Replace(".", "%2E");

            ParaUrl = ParaUrl.Replace("'", "%27");

            ParaUrl = ParaUrl.Replace("\"", "%22");

            ParaUrl = ParaUrl.Replace(",", "%2C");

            ParaUrl = ParaUrl.Replace("|", "%7C");

            ParaUrl = ParaUrl.Replace("[", "%5B");

            ParaUrl = ParaUrl.Replace("]", "%5D");

            ParaUrl = ParaUrl.Replace("{", "%7B");

            ParaUrl = ParaUrl.Replace("}", "%7D");

            ParaUrl = ParaUrl.Replace(":", "%3A");

            return ParaUrl;

        }



        /// <summary>
        /// 通过 IDToken 获取 AccessToken
        /// </summary>
        /// <param name="tokenParam"></param>
        /// <returns></returns>
        private async Task<OIDCTokenResponse> GetToken(CodeToTokenParams tokenParam)
        {
            string json = await PostFormAsync("/oidc/token", tokenParam).ConfigureAwait(false);
            OIDCTokenResponse res = jsonService.DeserializeObject<OIDCTokenResponse>(json);
            return res;
        }

        private string GenerateRandomString(int length = 30)
        {
            var rd = new Random((int)DateTime.Now.Ticks);
            var strAtt = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var resAtt = new Char[length];
            rd.Next(0, 62);

            var resStr = String.Join("", resAtt.Select(p => strAtt[rd.Next(0, 62)]).ToArray());
            return resStr;
        }

        /// <summary>
        /// 拼接处理 query 参数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        private string CreateQueryParams<T>(T obj)
        {
            string url = "";
            string json = m_JsonService.SerializeObject(obj);

            List<KeyValuePair<string, string>> dic = jsonService.DeserializeObject<Dictionary<string, string>>(json).ToList();

            for (int i = 0; i < dic.Count; i++)
            {
                if (dic[i].Value == null)
                {
                    continue;
                }

                string tail = dic.Count > i + 1 ? "&" : "";

                url += $"{dic[i].Key}={dic[i].Value}{tail}";
            }
            return url;
        }

        private async Task<LoginState> BuildLoginState(OIDCTokenResponse tokenRes)
        {
            LoginState state = new LoginState
            {
                AccessToken = tokenRes.AccessToken,
                IdToken = tokenRes.IdToken,
                RefreshToken = tokenRes.RefreshToken,
                ExpireAt = tokenRes.ExpiresIn,
                ParsedIDToken = await ParseIDToken(tokenRes.IdToken),
                ParsedAccessToken = await ParseAccessToken(tokenRes.AccessToken)
            };

            return state;
        }

        private async Task<bool> CheckAccessToken(string acccessToken)
        {
            string json = await PostFormAsync("/oidc/token/introspection", new { token = acccessToken, token_type_hint = "access_token", client_id = options.AppId, client_secret = options.AppSecret });

            return false;
        }

        private async Task<bool> CheckIdToken(string idToken, string accessToken)
        {
            string json = await GetAsync("/api/v2/oidc/validate_token", jsonService.SerializeObject(new { access_token = accessToken, id_token = idToken }));

            return false;
        }

        public void setAccessToken(string accessToken) => this.options.AccessToken = accessToken;

        #region 自动生成的方法
        ///<summary>
        /// 预检验验证码是否正确
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PreCheckCodeRespDto</returns>
        public async Task<PreCheckCodeRespDto> PreCheckCode(PreCheckCodeDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/pre-check-code", requestBody).ConfigureAwait(false);
            PreCheckCodeRespDto result = m_JsonService.DeserializeObject<PreCheckCodeRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 使用用户凭证登录
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>LoginTokenRespDto</returns>
        public async Task<LoginTokenRespDto> SignInByCredentials(SigninByCredentialsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/signin", requestBody).ConfigureAwait(false);
            LoginTokenRespDto result = m_JsonService.DeserializeObject<LoginTokenRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 使用移动端社会化登录
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>LoginTokenRespDto</returns>
        public async Task<LoginTokenRespDto> SignInByMobile(SigninByMobileDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/signin-by-mobile", requestBody).ConfigureAwait(false);
            LoginTokenRespDto result = m_JsonService.DeserializeObject<LoginTokenRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取支付宝 AuthInfo
        ///</summary>
        /// <param name="extIdpConnidentifier">外部身份源连接标志符</param>
        ///<returns>GetAlipayAuthInfoRespDto</returns>
        public async Task<GetAlipayAuthInfoRespDto> GetAlipayAuthInfo(string extIdpConnidentifier)
        {
            string httpResponse = await Request("GET", "/api/v3/get-alipay-authinfo", new Dictionary<string, object> {
        {"extIdpConnidentifier",extIdpConnidentifier },
    }).ConfigureAwait(false);
            GetAlipayAuthInfoRespDto result = m_JsonService.DeserializeObject<GetAlipayAuthInfoRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 生成用于登录的二维码
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GeneQRCodeRespDto</returns>
        public async Task<GeneQRCodeRespDto> GeneQrCode(GenerateQrcodeDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/gene-qrcode", requestBody).ConfigureAwait(false);
            GeneQRCodeRespDto result = m_JsonService.DeserializeObject<GeneQRCodeRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 查询二维码状态
        ///</summary>
        /// <param name="qrcodeId">二维码唯一 ID</param>
        ///<returns>CheckQRCodeStatusRespDto</returns>
        public async Task<CheckQRCodeStatusRespDto> CheckQrCodeStatus(string qrcodeId)
        {
            string httpResponse = await Request("GET", "/api/v3/check-qrcode-status", new Dictionary<string, object> {
        {"qrcodeId",qrcodeId },
    }).ConfigureAwait(false);
            CheckQRCodeStatusRespDto result = m_JsonService.DeserializeObject<CheckQRCodeStatusRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 使用二维码 ticket 换取 TokenSet
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>LoginTokenRespDto</returns>
        public async Task<LoginTokenRespDto> ExchangeTokenSetWithQrCodeTicket(ExchangeTokenSetWithQRcodeTicketDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/exchange-tokenset-with-qrcode-ticket", requestBody).ConfigureAwait(false);
            LoginTokenRespDto result = m_JsonService.DeserializeObject<LoginTokenRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 自建 APP 扫码登录：APP 端修改二维码状态
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> ChangeQrCodeStatus(ChangeQRCodeStatusDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/change-qrcode-status", requestBody).ConfigureAwait(false);
            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 发送短信
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>SendSMSRespDto</returns>
        public async Task<SendSMSRespDto> SendSms(SendSMSDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/send-sms", requestBody).ConfigureAwait(false);
            SendSMSRespDto result = m_JsonService.DeserializeObject<SendSMSRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 发送邮件
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>SendEmailRespDto</returns>
        public async Task<SendEmailRespDto> SendEmail(SendEmailDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/send-email", requestBody).ConfigureAwait(false);
            SendEmailRespDto result = m_JsonService.DeserializeObject<SendEmailRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户资料
        ///</summary>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withIdentities">是否获取 identities</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        ///<returns>UserSingleRespDto</returns>
        public async Task<UserSingleRespDto> GetProfile(bool withCustomData = false, bool withIdentities = false, bool withDepartmentIds = false)
        {
            string httpResponse = await Request("GET", "/api/v3/get-profile", new Dictionary<string, object> {
        {"withCustomData",withCustomData },
        {"withIdentities",withIdentities },
        {"withDepartmentIds",withDepartmentIds },
    }).ConfigureAwait(false);
            UserSingleRespDto result = m_JsonService.DeserializeObject<UserSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改用户资料
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UserSingleRespDto</returns>
        public async Task<UserSingleRespDto> UpdateProfile(UpdateUserProfileDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-profile", requestBody).ConfigureAwait(false);
            UserSingleRespDto result = m_JsonService.DeserializeObject<UserSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 绑定邮箱
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> BindEmail(BindEmailDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/bind-email", requestBody).ConfigureAwait(false);
            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 解绑邮箱
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> UnbindEmail(UnbindEmailDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/unbind-email", requestBody).ConfigureAwait(false);
            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 绑定手机号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> BindPhone(BindPhoneDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/bind-phone", requestBody).ConfigureAwait(false);
            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 解绑手机号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> UnbindPhone(UnbindPhoneDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/unbind-phone", requestBody).ConfigureAwait(false);
            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取密码强度和账号安全等级评分
        ///</summary>
        ///<returns>GetSecurityInfoRespDto</returns>
        public async Task<GetSecurityInfoRespDto> GetSecurityLevel()
        {
            string httpResponse = await Request("GET", "/api/v3/get-security-info").ConfigureAwait(false);
            GetSecurityInfoRespDto result = m_JsonService.DeserializeObject<GetSecurityInfoRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改密码
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> UpdatePassword(UpdatePasswordDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-password", requestBody).ConfigureAwait(false);
            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 发起修改邮箱的验证请求
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>VerifyUpdateEmailRequestRespDto</returns>
        public async Task<VerifyUpdateEmailRequestRespDto> VerifyUpdateEmailRequest(VerifyUpdateEmailRequestDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/verify-update-email-request", requestBody).ConfigureAwait(false);
            VerifyUpdateEmailRequestRespDto result = m_JsonService.DeserializeObject<VerifyUpdateEmailRequestRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改邮箱
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> UpdateEmail(UpdateEmailDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-email", requestBody).ConfigureAwait(false);
            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 发起修改手机号的验证请求
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>VerifyUpdatePhoneRequestRespDto</returns>
        public async Task<VerifyUpdatePhoneRequestRespDto> VerifyUpdatePhoneRequest(VerifyUpdatePhoneRequestDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/verify-update-phone-request", requestBody).ConfigureAwait(false);
            VerifyUpdatePhoneRequestRespDto result = m_JsonService.DeserializeObject<VerifyUpdatePhoneRequestRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改手机号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> UpdatePhone(UpdatePhoneDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-phone", requestBody).ConfigureAwait(false);
            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 发起忘记密码请求
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PasswordResetVerifyResp</returns>
        public async Task<PasswordResetVerifyResp> VerifyResetPasswordRequest(VerifyResetPasswordRequestDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/verify-reset-password-request", requestBody).ConfigureAwait(false);
            PasswordResetVerifyResp result = m_JsonService.DeserializeObject<PasswordResetVerifyResp>(httpResponse);
            return result;
        }
        ///<summary>
        /// 忘记密码
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> ResetPassword(ResetPasswordDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/reset-password", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 发起注销账号请求
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>VerifyDeleteAccountRequestRespDto</returns>
        public async Task<VerifyDeleteAccountRequestRespDto> VeirfyDeleteAccountRequest(VerifyDeleteAccountRequestDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/verify-delete-account-request", requestBody).ConfigureAwait(false);
            VerifyDeleteAccountRequestRespDto result = m_JsonService.DeserializeObject<VerifyDeleteAccountRequestRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 注销账户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteAccount(DeleteAccounDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-account", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取服务器公开信息
        ///</summary>
        ///<returns>SystemInfoResp</returns>
        public async Task<SystemInfoResp> GetSystemInfo()
        {
            string httpResponse = await Request("GET", "/api/v3/system").ConfigureAwait(false);
            SystemInfoResp result = m_JsonService.DeserializeObject<SystemInfoResp>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取国家列表
        ///</summary>
        ///<returns>GetCountryListRespDto</returns>
        public async Task<GetCountryListRespDto> GetCountryList()
        {
            string httpResponse = await Request("GET", "/api/v3/get-country-list").ConfigureAwait(false);
            GetCountryListRespDto result = m_JsonService.DeserializeObject<GetCountryListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 发起绑定 MFA 认证要素请求
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>SendEnrollFactorRequestRespDto</returns>
        public async Task<SendEnrollFactorRequestRespDto> SendEnrollFactorRequest(SendEnrollFactorRequestDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/send-enroll-factor-request", requestBody).ConfigureAwait(false);
            SendEnrollFactorRequestRespDto result = m_JsonService.DeserializeObject<SendEnrollFactorRequestRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 绑定 MFA 认证要素
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>EnrollFactorRespDto</returns>
        public async Task<EnrollFactorRespDto> EnrollFactor(EnrollFactorDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/enroll-factor", requestBody).ConfigureAwait(false);
            EnrollFactorRespDto result = m_JsonService.DeserializeObject<EnrollFactorRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 解绑 MFA 认证要素
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ResetFactorRespDto</returns>
        public async Task<ResetFactorRespDto> ResetFactor(RestFactorDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/reset-factor", requestBody).ConfigureAwait(false);
            ResetFactorRespDto result = m_JsonService.DeserializeObject<ResetFactorRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取绑定的所有 MFA 认证要素
        ///</summary>
        ///<returns>ListEnrolledFactorsRespDto</returns>
        public async Task<ListEnrolledFactorsRespDto> ListEnrolledFactors()
        {
            string httpResponse = await Request("GET", "/api/v3/list-enrolled-factors").ConfigureAwait(false);
            ListEnrolledFactorsRespDto result = m_JsonService.DeserializeObject<ListEnrolledFactorsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取绑定的某个 MFA 认证要素
        ///</summary>
        /// <param name="factorId">MFA Factor ID</param>
        ///<returns>GetFactorRespDto</returns>
        public async Task<GetFactorRespDto> GetFactor(string factorId)
        {
            string httpResponse = await Request("GET", "/api/v3/get-factor", new Dictionary<string, object> {
        {"factorId",factorId },
    }).ConfigureAwait(false);
            GetFactorRespDto result = m_JsonService.DeserializeObject<GetFactorRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取可绑定的 MFA 认证要素
        ///</summary>
        ///<returns>ListFactorsToEnrollRespDto</returns>
        public async Task<ListFactorsToEnrollRespDto> ListFactorsToEnroll()
        {
            string httpResponse = await Request("GET", "/api/v3/list-factors-to-enroll").ConfigureAwait(false);
            ListFactorsToEnrollRespDto result = m_JsonService.DeserializeObject<ListFactorsToEnrollRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 绑定外部身份源
        ///</summary>
        /// <param name="extIdpConnIdentifier">外部身份源连接唯一标志</param>
        /// <param name="appId">Authing 应用 ID</param>
        /// <param name="idToken">用户的 id_token</param>
        ///<returns>GenerateBindExtIdpLinkRespDto</returns>
        public async Task<GenerateBindExtIdpLinkRespDto> LinkExtIdp(string extIdpConnIdentifier, string appId, string idToken)
        {
            string httpResponse = await Request("GET", "/api/v3/link-extidp", new Dictionary<string, object> {
        {"ext_idp_conn_identifier",extIdpConnIdentifier },
        {"app_id",appId },
        {"id_token",idToken },
    }).ConfigureAwait(false);
            GenerateBindExtIdpLinkRespDto result = m_JsonService.DeserializeObject<GenerateBindExtIdpLinkRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 生成绑定外部身份源的链接
        ///</summary>
        /// <param name="extIdpConnIdentifier">外部身份源连接唯一标志</param>
        /// <param name="appId">Authing 应用 ID</param>
        /// <param name="idToken">用户的 id_token</param>
        ///<returns>GenerateBindExtIdpLinkRespDto</returns>
        public async Task<GenerateBindExtIdpLinkRespDto> GenerateLinkExtIdpUrl(string extIdpConnIdentifier, string appId, string idToken)
        {
            string httpResponse = await Request("GET", "/api/v3/generate-link-extidp-url", new Dictionary<string, object> {
        {"ext_idp_conn_identifier",extIdpConnIdentifier },
        {"app_id",appId },
        {"id_token",idToken },
    }).ConfigureAwait(false);
            GenerateBindExtIdpLinkRespDto result = m_JsonService.DeserializeObject<GenerateBindExtIdpLinkRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 解绑外部身份源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> UnbindExtIdp(UnbindExtIdpDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/unlink-extidp", requestBody).ConfigureAwait(false);
            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取绑定的外部身份源
        ///</summary>
        ///<returns>GetIdentitiesRespDto</returns>
        public async Task<GetIdentitiesRespDto> GetIdentities()
        {
            string httpResponse = await Request("GET", "/api/v3/get-identities").ConfigureAwait(false);
            GetIdentitiesRespDto result = m_JsonService.DeserializeObject<GetIdentitiesRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取应用开启的外部身份源列表
        ///</summary>
        ///<returns>GetExtIdpsRespDto</returns>
        public async Task<GetExtIdpsRespDto> GetExtIdps()
        {
            string httpResponse = await Request("GET", "/api/v3/get-extidps").ConfigureAwait(false);
            GetExtIdpsRespDto result = m_JsonService.DeserializeObject<GetExtIdpsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 注册
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UserSingleRespDto</returns>
        public async Task<UserSingleRespDto> SignUp(SignUpDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/signup", requestBody).ConfigureAwait(false);
            UserSingleRespDto result = m_JsonService.DeserializeObject<UserSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 解密微信小程序数据
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>DecryptWechatMiniProgramDataRespDto</returns>
        public async Task<DecryptWechatMiniProgramDataRespDto> DecryptWechatMiniProgramData(DecryptWechatMiniProgramDataDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/decrypt-wechat-miniprogram-data", requestBody).ConfigureAwait(false);
            DecryptWechatMiniProgramDataRespDto result = m_JsonService.DeserializeObject<DecryptWechatMiniProgramDataRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取小程序的手机号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GetWechatMiniProgramPhoneRespDto</returns>
        public async Task<GetWechatMiniProgramPhoneRespDto> GetWechatMiniprogramPhone(GetWechatMiniProgramPhoneDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-wechat-miniprogram-phone", requestBody).ConfigureAwait(false);
            GetWechatMiniProgramPhoneRespDto result = m_JsonService.DeserializeObject<GetWechatMiniProgramPhoneRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取 Authing 服务器缓存的微信小程序、公众号 Access Token
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GetWechatAccessTokenRespDto</returns>
        public async Task<GetWechatAccessTokenRespDto> GetWechatMpAccessToken(GetWechatAccessTokenDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-wechat-access-token", requestBody).ConfigureAwait(false);
            GetWechatAccessTokenRespDto result = m_JsonService.DeserializeObject<GetWechatAccessTokenRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取登录日志
        ///</summary>
        /// <param name="appId">应用 ID，可根据应用 ID 筛选。默认不传获取所有应用的登录历史。</param>
        /// <param name="clientIp">客户端 IP，可根据登录时的客户端 IP 进行筛选。默认不传获取所有登录 IP 的登录历史。</param>
        /// <param name="success">是否登录成功，可根据是否登录成功进行筛选。默认不传获取的记录中既包含成功也包含失败的的登录历史。</param>
        /// <param name="start">开始时间，为单位为毫秒的时间戳</param>
        /// <param name="end">结束时间，为单位为毫秒的时间戳</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>GetLoginHistoryRespDto</returns>
        public async Task<GetLoginHistoryRespDto> GetLoginHistory(long end = 0, long start = 0, bool success = false, string clientIp = null, string appId = null, long page = 1, long limit = 10)
        {
            string httpResponse = await Request("GET", "/api/v3/get-my-login-history", new Dictionary<string, object> {
        {"appId",appId },
        {"clientIp",clientIp },
        {"success",success },
        {"start",start },
        {"end",end },
        {"page",page },
        {"limit",limit },
    }).ConfigureAwait(false);
            GetLoginHistoryRespDto result = m_JsonService.DeserializeObject<GetLoginHistoryRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取登录应用
        ///</summary>
        ///<returns>GetLoggedInAppsRespDto</returns>
        public async Task<GetLoggedInAppsRespDto> GetLoggedInApps()
        {
            string httpResponse = await Request("GET", "/api/v3/get-my-logged-in-apps").ConfigureAwait(false);
            GetLoggedInAppsRespDto result = m_JsonService.DeserializeObject<GetLoggedInAppsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取具备访问权限的应用
        ///</summary>
        ///<returns>GetAccessibleAppsRespDto</returns>
        public async Task<GetAccessibleAppsRespDto> GetAccessibleApps()
        {
            string httpResponse = await Request("GET", "/api/v3/get-my-accessible-apps").ConfigureAwait(false);
            GetAccessibleAppsRespDto result = m_JsonService.DeserializeObject<GetAccessibleAppsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取租户列表
        ///</summary>
        ///<returns>GetTenantListRespDto</returns>
        public async Task<GetTenantListRespDto> GetTenantList()
        {
            string httpResponse = await Request("GET", "/api/v3/get-my-tenant-list").ConfigureAwait(false);
            GetTenantListRespDto result = m_JsonService.DeserializeObject<GetTenantListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取角色列表
        ///</summary>
        /// <param name="nameSpace">所属权限分组的 code</param>
        ///<returns>RoleListRespDto</returns>
        public async Task<RoleListRespDto> GetRoleList(string nameSpace = null)
        {
            string httpResponse = await Request("GET", "/api/v3/get-my-role-list", new Dictionary<string, object> {
        {"namespace",nameSpace },
    }).ConfigureAwait(false);
            RoleListRespDto result = m_JsonService.DeserializeObject<RoleListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取分组列表
        ///</summary>
        ///<returns>GroupListRespDto</returns>
        public async Task<GroupListRespDto> GetGroupList()
        {
            string httpResponse = await Request("GET", "/api/v3/get-my-group-list").ConfigureAwait(false);
            GroupListRespDto result = m_JsonService.DeserializeObject<GroupListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取部门列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="withCustomData">是否获取部门的自定义数据</param>
        /// <param name="sortBy">排序依据，如 部门创建时间、加入部门时间、部门名称、部门标志符</param>
        /// <param name="orderBy">增序或降序</param>
        ///<returns>UserDepartmentPaginatedRespDto</returns>
        public async Task<UserDepartmentPaginatedRespDto> GetDepartmentList(long page = 1, long limit = 10, bool withCustomData = false, string sortBy = "JoinDepartmentAt", string orderBy = "Desc")
        {
            string httpResponse = await Request("GET", "/api/v3/get-my-department-list", new Dictionary<string, object> {
        {"page",page },
        {"limit",limit },
        {"withCustomData",withCustomData },
        {"sortBy",sortBy },
        {"orderBy",orderBy },
    }).ConfigureAwait(false);
            UserDepartmentPaginatedRespDto result = m_JsonService.DeserializeObject<UserDepartmentPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取被授权的资源列表
        ///</summary>
        /// <param name="nameSpace">所属权限分组的 code</param>
        /// <param name="resourceType">资源类型，如 数据、API、菜单、按钮</param>
        ///<returns>AuthorizedResourcePaginatedRespDto</returns>
        public async Task<AuthorizedResourcePaginatedRespDto> GetAuthorizedResources(string resourceType = null, string nameSpace = null)
        {
            string httpResponse = await Request("GET", "/api/v3/get-my-authorized-resources", new Dictionary<string, object> {
        {"namespace",nameSpace },
        {"resourceType",resourceType },
    }).ConfigureAwait(false);
            AuthorizedResourcePaginatedRespDto result = m_JsonService.DeserializeObject<AuthorizedResourcePaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 文件上传
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UploadRespDto</returns>
        public async Task<UploadRespDto> Upload(UploadDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v2/upload", requestBody).ConfigureAwait(false);
            UploadRespDto result = m_JsonService.DeserializeObject<UploadRespDto>(httpResponse);
            return result;
        }


        #endregion

        #region 基于 signInByCredentials 封装的登录方式 BEGIN

        /// <summary>
        /// 使用邮箱 + 密码登录
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public async Task<LoginTokenRespDto> SignInByEmailPassword(string email, string password, SignInOptionsDto option = null)
        {
            SigninByCredentialsDto dto = new SigninByCredentialsDto
            {
                Connection = SigninByCredentialsDto.connection.PASSWORD,
                PasswordPayload = new SignInByPasswordPayloadDto
                {
                    Email = email,
                    Password = password
                },
                Options = option
            };

            if (options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_POST)
            {
                dto.Client_id = options.AppId;
                dto.Client_secret = options.AppSecret;
            }

            return await SignInByCredentials(dto);
        }

        /// <summary>
        /// 使用手机号 + 密码登录
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public async Task<LoginTokenRespDto> SignInByPhonePassword(string phone, string password, SignInOptionsDto option = null)
        {
            SigninByCredentialsDto dto = new SigninByCredentialsDto
            {
                Connection = SigninByCredentialsDto.connection.PASSWORD,
                PasswordPayload = new SignInByPasswordPayloadDto
                {
                    Phone = phone,
                    Password = password
                },
                Options = option
            };

            if (options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_POST)
            {
                dto.Client_id = options.AppId;
                dto.Client_secret = options.AppSecret;
            }

            return await SignInByCredentials(dto);
        }

        /// <summary>
        /// 使用用户名 + 密码登录
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public async Task<LoginTokenRespDto> SignInByUsernamePassword(string username, string password, SignInOptionsDto option = null)
        {
            SigninByCredentialsDto dto = new SigninByCredentialsDto
            {
                Connection = SigninByCredentialsDto.connection.PASSWORD,
                PasswordPayload = new SignInByPasswordPayloadDto
                {
                    Username = username,
                    Password = password
                },
                Options = option
            };

            if (options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_POST)
            {
                dto.Client_id = options.AppId;
                dto.Client_secret = options.AppSecret;
            }

            return await SignInByCredentials(dto);
        }

        /// <summary>
        /// 使用用户名 + 密码登录
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public async Task<LoginTokenRespDto> SignInByAccountPassword(string account, string password, SignInOptionsDto option = null)
        {
            SigninByCredentialsDto dto = new SigninByCredentialsDto
            {
                Connection = SigninByCredentialsDto.connection.PASSWORD,
                PasswordPayload = new SignInByPasswordPayloadDto
                {
                    Account = account,
                    Password = password
                },
                Options = option
            };

            if (options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_POST)
            {
                dto.Client_id = options.AppId;
                dto.Client_secret = options.AppSecret;
            }

            return await SignInByCredentials(dto);
        }

        /// <summary>
        /// 使用邮箱 + 验证码登录
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public async Task<LoginTokenRespDto> SignInByEmailPassCode(string email, string passCode, SignInOptionsDto option = null)
        {
            SigninByCredentialsDto dto = new SigninByCredentialsDto
            {
                Connection = SigninByCredentialsDto.connection.PASSCODE,
                PassCodePayload = new SignInByPassCodePayloadDto
                {
                    Email = email,
                    PassCode = passCode
                },
                Options = option
            };

            if (options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_POST)
            {
                dto.Client_id = options.AppId;
                dto.Client_secret = options.AppSecret;
            }

            return await SignInByCredentials(dto);
        }

        /// <summary>
        /// 使用手机号 + 验证码登录
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public async Task<LoginTokenRespDto> SignInByPhonePassCode(string phone, string passCode, string phoneCountryCode = null, SignInOptionsDto option = null)
        {
            SigninByCredentialsDto dto = new SigninByCredentialsDto
            {
                Connection = SigninByCredentialsDto.connection.PASSCODE,
                PassCodePayload = new SignInByPassCodePayloadDto
                {
                    Phone = phone,
                    PhoneCountryCode = phoneCountryCode,
                    PassCode = passCode
                },
                Options = option
            };

            if (options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_POST)
            {
                dto.Client_id = options.AppId;
                dto.Client_secret = options.AppSecret;
            }

            return await SignInByCredentials(dto);
        }

        /// <summary>
        /// 使用 AD 账号密码登录
        /// </summary>
        /// <param name="sAMAccountName"> Windows AD 用户目录中账号的 sAMAccountName</param>
        /// <param name="password"> 用户密码，默认不加密。Authing 所有 API 均通过 HTTPS 协议对密码进行安全传输，可以在一定程度上保证安全性。
        /// 如果你还需要更高级别的安全性，我们还支持 `RSA256` 和国密 `SM2` 的密码加密方式。详情见可选参数 `options.passwordEncryptType`。</param>
        /// <param name="option"></param>
        /// <returns></returns>
        public async Task<LoginTokenRespDto> SignInByAD(string sAMAccountName, string password, SignInOptionsDto option = null)
        {
            SigninByCredentialsDto dto = new SigninByCredentialsDto
            {
                Connection = SigninByCredentialsDto.connection.AD,
                AdPayload = new SignInByAdPayloadDto
                {
                    SAMAccountName = sAMAccountName,
                    Password = password,
                },
                Options = option
            };

            if (options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_POST)
            {
                dto.Client_id = options.AppId;
                dto.Client_secret = options.AppSecret;
            }

            return await SignInByCredentials(dto);
        }

        /// <summary>
        /// 使用 LDAP 账号密码登录
        /// </summary>
        /// <param name="sAMAccountName"> Windows AD 用户目录中账号的 sAMAccountName</param>
        /// <param name="password"> 用户密码，默认不加密。Authing 所有 API 均通过 HTTPS 协议对密码进行安全传输，可以在一定程度上保证安全性。
        /// 如果你还需要更高级别的安全性，我们还支持 `RSA256` 和国密 `SM2` 的密码加密方式。详情见可选参数 `options.passwordEncryptType`。</param>
        /// <param name="option"></param>
        /// <returns></returns>
        public async Task<LoginTokenRespDto> signInByLDAP(string sAMAccountName, string password, SignInOptionsDto option = null)
        {
            SigninByCredentialsDto dto = new SigninByCredentialsDto
            {
                Connection = SigninByCredentialsDto.connection.LDAP,
                LdapPayload = new SignInByLdapPayloadDto
                {
                    SAMAccountName = sAMAccountName,
                    Password = password,
                },
                Options = option
            };

            if (options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_POST)
            {
                dto.Client_id = options.AppId;
                dto.Client_secret = options.AppSecret;
            }

            return await SignInByCredentials(dto);
        }

        #endregion

        #region 基于 signup 封装的注册方式 BEGIN

        /// <summary>
        /// 使用邮箱 + 密码注册
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public async Task<UserSingleRespDto> SignUpByEmailPassword(string email, string password, SignUpOptionsDto option = null)
        {
            SignUpDto dto = new SignUpDto
            {
                Connection = SignUpDto.connection.PASSWORD,
                PasswordPayload = new SignUpByPasswordDto
                {
                    Email = email,
                    Password = password,
                },
                Options = option
            };

            return await SignUp(dto);
        }

        /// <summary>
        /// 使用邮箱 + 验证码注册
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public async Task<UserSingleRespDto> SignUpByEmailCode(string email, string passCode, SignUpOptionsDto option = null)
        {
            SignUpDto dto = new SignUpDto
            {
                Connection = SignUpDto.connection.PASSCODE,
                PassCodePayload = new SignUpByPassCodeDto
                {
                    Email = email,
                    PassCode = passCode,
                },
                Options = option
            };

            return await SignUp(dto);
        }

        /// <summary>
        /// 使用手机号 + 验证码注册
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public async Task<UserSingleRespDto> SignUpByPhoneCode(string phone, string passCode, string phoneCountryCode = null, SignUpOptionsDto option = null)
        {
            SignUpDto dto = new SignUpDto
            {
                Connection = SignUpDto.connection.PASSCODE,
                PassCodePayload = new SignUpByPassCodeDto
                {
                    Phone = phone,
                    PhoneCountryCode = phoneCountryCode,
                    PassCode = passCode,
                },
                Options = option,
            };

            return await SignUp(dto);
        }

        /// <summary>
        /// 使用手机号 + 验证码注册
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public async Task<UserSingleRespDto> SignUpByPhoneCode(string phone, string passCode, string phoneCountryCode = null, SignUpOptionsDto option = null,SignUpProfileDto profile = null)
        {
            SignUpDto dto = new SignUpDto
            {
                Connection = SignUpDto.connection.PASSCODE,
                PassCodePayload = new SignUpByPassCodeDto
                {
                    Phone = phone,
                    PhoneCountryCode = phoneCountryCode,
                    PassCode = passCode,
                },
                Options = option,
                Profile = profile
            };

            return await SignUp(dto);
        }

        #endregion
    }
}

