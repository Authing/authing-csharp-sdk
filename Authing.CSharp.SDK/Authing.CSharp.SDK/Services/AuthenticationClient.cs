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
        private JwkSet jwks;

        private IRegexService regexService = new RegexService();
        private IJsonService jsonService = new JsonService();
        private IStringService stringService = new StringService();

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="options"></param>
        public AuthenticationClient(AuthenticationClientInitOptions options)
            : base(options.Domain)
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
            this.domain = regexService.DomainC14n(options.Domain);

            Init();
        }

        private void Init()
        {
            if (options.ServerJWKS != null)
            {
                this.jwks = options.ServerJWKS;
            }
            else
            {
                try
                {
                    this.jwks = GetJWKSJSONAsync().Result;
                }
                catch (Exception exp)
                {
                    throw new Exception("自动获取认证服务器 JWKS 公钥失败, 请检查域名是否正确, 或手动指定 serverJWKS 参数:" + exp.Message);
                }
            }
        }

#if NETFRAMEWORK

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
                RedirectUri = string.IsNullOrWhiteSpace(redirectUri) ? options.RediretUri : redirectUri
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
            string json = await GetAsync("/oidc/.well-known/jwks.json", "").ConfigureAwait(false);

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
                RedirectUri = string.IsNullOrWhiteSpace(redirectUri) ? this.options.RediretUri : redirectUri,
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
            var result = BuildLoginState(response);
            return result;
        }

        /// <summary>
        /// 用 Access Token 获取用户身份信息
        /// </summary>
        /// <param name="accessToken">Access Token</param>
        /// <returns></returns>
        public async Task<UserInfo> GetUserInfo(string accessToken)
        {
            string json = await GetWithBearerTokenAsync("/oidc/me", "", accessToken).ConfigureAwait(false);
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

            string json = await PostAsync("POST", "/oidc/token", param).ConfigureAwait(false);
            OIDCTokenResponse res = jsonService.DeserializeObject<OIDCTokenResponse>(json);
            return BuildLoginState(res);
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
        public IDToken ParseIDToken(string token)
        {
            IDToken idToken = new IDToken();
            string jsonStr = "";
            try
            {
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
        public AccessToken ParseAccessToken(string token)
        {
            string jsonStr = "";
            try
            {
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
            string json = await PostAsync("POST", "/oidc/token", tokenParam).ConfigureAwait(false);
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

        private LoginState BuildLoginState(OIDCTokenResponse tokenRes)
        {
            LoginState state = new LoginState
            {
                AccessToken = tokenRes.AccessToken,
                IdToken = tokenRes.IdToken,
                RefreshToken = tokenRes.RefreshToken,
                ExpireAt = tokenRes.ExpiresIn,
                ParsedIDToken = ParseIDToken(tokenRes.IdToken),
                ParsedAccessToken = ParseAccessToken(tokenRes.AccessToken)
            };

            return state;
        }

        private async Task<bool> CheckAccessToken(string acccessToken)
        {
            string json = await PostAsync("POST", "/oidc/token/introspection", new { token = acccessToken, token_type_hint = "access_token", client_id = options.AppId, client_secret = options.AppSecret });

            return false;
        }

        private async Task<bool> CheckIdToken(string idToken, string accessToken)
        {
            string json = await GetAsync("/api/v2/oidc/validate_token", jsonService.SerializeObject(new { access_token = accessToken, id_token = idToken }));

            return false;
        }



    }

}

