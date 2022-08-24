using Authing.CSharp.SDK.Extensions;
using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Models.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Services
{
    public partial class AuthenticationClient
    {
        public string BuildAuthorizeUrl(IProtocolInterface option)
        {
            if (string.IsNullOrWhiteSpace(m_BaseUrl))
            {
                throw new ArgumentException("请在初始化 AuthenticationClient 时传入应用域名 Host 参数，形如：https://app1.authing.cn");
            }

            if (option is OidcOption)
            {
                return BuildOidcAuthorizeUrl(option as OidcOption);
            }

            if (option is OauthOption)
            {
                return BuildOauthAuthorizeUrl(option as OauthOption);
            }

            if (option is CasOption)
            {
                return BuildCasAuthorizeUrl(option as CasOption);
            }

            if (option is SamlOption)
            {
                return BuildSamlAuthorizeUrl();
            }

            throw new ArgumentException("接口型实现必须是 OidcOption, OauthOption, CasOption 其中一种");
        }

        /// <summary>
        /// 拼接 OIDC 协议授权链接
        /// </summary>
        /// <param name="option">OIDC 授权类</param>
        /// <returns></returns>
        private string BuildOidcAuthorizeUrl(OidcOption option)
        {
            option.Scope ??= "openid profile email phone address";
            var res = new
            {
                client_id = option?.AppId ?? options.AppId,
                scope = option.Scope,
                state = option?.State ?? stringService.GenerateRandomString(12),
                nonce = option?.Nonce ?? stringService.GenerateRandomString(12),
                response_mode = option?.ResponseMode?.ToString().ToLower(),
                response_type = !(option?.ResponseType is null) ? option.ResponseType.ToString().ToLower() : "code",
                redirect_uri = option?.RedirectUri ?? options.RedirectUri,
                prompt = option.Scope.Contains("offline_access") ? "consent" : "",
            }.Convert2QueryParams();

            return $"{options.Host ?? ConfigService.BASE_URL}/oidc/auth{res}";
        }

        /// <summary>
        /// 拼接 OAuth 2.0 协议授权链接
        /// </summary>
        /// <param name="option">OAuth 授权类</param>
        /// <returns></returns>
        private string BuildOauthAuthorizeUrl(OauthOption option)
        {
            var rd = new Random();
            var param = new
            {
                state = option.State ?? rd.Next(10, 99).ToString(),
                scope = option.Scope ?? "user",
                client_id = option.AppId ?? options.AppId,
                redirect_uri = option.RedirectUri ?? options.RedirectUri,
                response_type = !(option.ResponseType is null) ? option.ResponseType.ToString().ToLower() : "code",
            }.Convert2QueryParams();

            return $"{options.Host}/oauth/auth{param}";
        }

        /// <summary>
        /// 拼接 CAS 协议授权链接
        /// </summary>
        /// <param name="option">CAS 授权类</param>
        /// <returns></returns>                       
        private string BuildCasAuthorizeUrl(CasOption option)
        {
            return option.Service is null
                ? $"{options.Host}/cas-idp/{options.AppId}"
                : $"{options.Host}/cas-idp/{options.AppId}?service={option.Service}";
        }

        public string BuildSamlAuthorizeUrl()
        {
            return $"{options.Host}/api/v2/saml-idp/{options.AppId}";
        }

        /// <summary>
        /// Code 换取 AccessToken
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<CodeToTokenRes> GetAccessTokenByCode(string code)
        {
            if (string.IsNullOrWhiteSpace(options.AppSecret) &&
               options.TokenEndPointAuthMethod != TokenEndPointAuthMethod.NONE)
            {
                throw new ArgumentException("请在初始化 AuthenticationClient 时传入 appId 和 secret 参数");
            }

            var url = options.Protocol == Protocol.OAUTH ? $"oauth/token" : $"oidc/token";
            string jsonResult;
            switch (options.TokenEndPointAuthMethod)
            {
                case TokenEndPointAuthMethod.CLIENT_SECRET_POST:
                    jsonResult = await GetAsync(url, new Dictionary<string, string>()
                    {
                        { "client_id", options.AppId },
                        { "client_secret", options.AppSecret },
                        { "grant_type", "authorization_code" },
                        { "code", code },
                        { "redirect_uri", options.RedirectUri },
                    }).ConfigureAwait(false);
                    return m_JsonService.DeserializeObject<CodeToTokenRes>(jsonResult);
                case TokenEndPointAuthMethod.CLIENT_SECRET_BASIC:

                    jsonResult = await GetAsync(url, new Dictionary<string, string>()
                        {
                            { "grant_type", "authorization_code" },
                            { "code", code },
                            { "redirect_uri", options.RedirectUri },
                        }, new Dictionary<string, string> { { "Authorization",
                        $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"{options.AppId}:{options.AppSecret}"))}"} }).ConfigureAwait(false);
                    return m_JsonService.DeserializeObject<CodeToTokenRes>(jsonResult);
                case TokenEndPointAuthMethod.NONE:
                    jsonResult = await GetAsync(url, new Dictionary<string, string>()
                    {
                        { "client_id", options.AppId },
                        //{ "client_secret", Options.Secret },
                        { "grant_type", "authorization_code" },
                        { "code", code },
                        { "redirect_uri", options.RedirectUri },
                    }).ConfigureAwait(false);
                    return m_JsonService.DeserializeObject<CodeToTokenRes>(jsonResult);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// AccessToken 换取用户信息
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public async Task<UserInfo> GetUserInfoByAccessToken(string token)
        {
            var endPoint = options.Protocol == Protocol.OAUTH
               ? $"oauth/me?access_token={token}"
               : $"oidc/me?access_token={token}";
            UserInfo res;
            string json;
            switch (options.Protocol)
            {
                case Protocol.OAUTH:
                    json = await GetAsync(endPoint).ConfigureAwait(false);
                    break;
                case Protocol.OIDC:
                    json = await GetAsync(endPoint, "", token).ConfigureAwait(false);
                    break;
                case Protocol.SAML:
                case Protocol.CAS:
                    json = await GetAsync(endPoint).ConfigureAwait(false);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }


            res = m_JsonService.DeserializeObject<UserInfo>(json);
            return res;
        }

        public async Task<RefreshTokenRes> GetNewAccessTokenByRefreshToken(string refreshToken)
        {
            var _ = options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new ArgumentException("初始化 AuthenticationClient 时传入的 protocol 参数必须为 oauth 或 oidc，请检查参数")
            };
            if (options?.AppSecret == null && options?.AppId == null && options.TokenEndPointAuthMethod != TokenEndPointAuthMethod.NONE)
            {
                throw new ArgumentException("请在初始化 AuthenticationClient 时传入 appId 和 secret 参数");
            }

            if (options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_POST)
            {
                return await GetNewAccessTokenByRefreshTokenWithClientSecretPost(refreshToken).ConfigureAwait(false);
            }

            if (options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_BASIC)
            {
                return await GetNewAccessTokenByRefreshTokenWithClientSecretBasic(refreshToken).ConfigureAwait(false);
            }

            if (options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.NONE)
            {
                return await GetNewAccessTokenByRefreshTokenWithNone(refreshToken).ConfigureAwait(false);
            }

            throw new ArgumentException("请检查参数 TokenEndPointAuthMethod");
        }

        private async Task<RefreshTokenRes> GetNewAccessTokenByRefreshTokenWithClientSecretPost(string refreshToken)
        {
            var api = options.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new ArgumentOutOfRangeException()
            };

            var param = new Dictionary<string, string>()
            {
                { "client_id", $"{options.AppId}" },
                { "client_secret", $"{options.AppSecret}" },
                { "grant_type", "refresh_token" },
                { "refresh_token", refreshToken },

            };
            string json = await GetAsync(api, param).ConfigureAwait(false);

            var result = m_JsonService.DeserializeObject<RefreshTokenRes>(json);

            return result;
        }

        private async Task<RefreshTokenRes> GetNewAccessTokenByRefreshTokenWithClientSecretBasic(string refreshToken)
        {
            var api = options.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new ArgumentOutOfRangeException()
            };

            var param = new Dictionary<string, string>()
            {
                { "grant_type", "refresh_token" },
                { "refresh_token", refreshToken }
            };
            string json = await GetAsync(api, param).ConfigureAwait(false);

            var result = m_JsonService.DeserializeObject<RefreshTokenRes>(json);

            return result;
        }

        private async Task<RefreshTokenRes> GetNewAccessTokenByRefreshTokenWithNone(string refreshToken)
        {
            var api = options.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new ArgumentOutOfRangeException()
            };

            var param = new Dictionary<string, string>()
            {
                { "client_id", $"{options.AppId}" },
                { "grant_type", "refresh_token" },
                { "refresh_token", refreshToken }
            };

            string json = await GetAsync(api, param).ConfigureAwait(false);

            RefreshTokenRes result = m_JsonService.DeserializeObject<RefreshTokenRes>(json);

            return result;
        }

        /// <summary>
        /// 检查 Access token 或 Refresh token 的状态
        /// </summary>
        /// <param name="token">用户的 Refresh token 或 Access token</param>
        /// <returns></returns>
        public async Task<IntrospectTokenRes> IntrospectToken(string token)
        {
            var api = options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token/introspection",
                Protocol.OAUTH => "oauth/token/introspection",
                _ => throw new Exception("初始化 AuthenticationClient 时传入的 protocol 参数必须为 oauth 或 oidc，请检查参数")
            };
            if (options?.AppSecret == null && options?.AppId == null && options.TokenEndPointAuthMethod != TokenEndPointAuthMethod.NONE)
            {
                throw new Exception("请在初始化 AuthenticationClient 时传入 appId 和 secret 参数");
            }

            if (options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_POST)
            {
                return await IntrospectTokenWithClientSecretPost(api, token).ConfigureAwait(false);
            }

            if (options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_BASIC)
            {
                return await IntrospectTokenWithClientSecretBasic(api, token).ConfigureAwait(false);
            }

            if (options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.NONE)
            {
                return await IntrospectTokenWithNone(api, token).ConfigureAwait(false);
            }

            throw new Exception(
                "初始化 AuthenticationClient 时传入的 revocationEndPointAuthMethod 参数可选值为 client_secret_base、client_secret_post、none，请检查参数");
        }

        private async Task<IntrospectTokenRes> IntrospectTokenWithClientSecretPost(string url, string token)
        {
            var json = await GetAsync(url, new Dictionary<string, string>()
            {
                { "client_id", options.AppId },
                { "client_secret", options.AppSecret },
                { "token", token },
            }).ConfigureAwait(false);
            return m_JsonService.DeserializeObject<IntrospectTokenRes>(json);
        }

        private async Task<IntrospectTokenRes> IntrospectTokenWithClientSecretBasic(string url, string token)
        {
            var json = await GetAsync(url, new Dictionary<string, string>()
                {
                    { "token", token },
                },
                new Dictionary<string, string>()
                {
                    {
                        "Authorization",
                        $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"{options.AppId}:{options.AppSecret}"))}"
                    }
                }).ConfigureAwait(false);

            return m_JsonService.DeserializeObject<IntrospectTokenRes>(json);
        }

        private async Task<IntrospectTokenRes> IntrospectTokenWithNone(string url, string token)
        {
            var result = await GetAsync(url, new Dictionary<string, string>()
            {
                { "client_id", options.AppId },
                { "token", token },
            }).ConfigureAwait(false);
            return m_JsonService.DeserializeObject<IntrospectTokenRes>(result);
        }

        public async Task<ValidateTokenRes> ValidateToken(ValidateTokenParams param)
        {
            if (string.IsNullOrWhiteSpace(param.AccessToken) && string.IsNullOrWhiteSpace(param.IdToken))
                throw new AggregateException("请在传入的参数对象中包含 accessToken 或 idToken 属性");
            if (param.AccessToken?.Length > 0 && param.IdToken?.Length > 0)
                throw new ArgumentException("accessToken 和 idToken 只能传入一个，不能同时传入");

            var url = $"api/v2/oidc/validate_token";
            url += !string.IsNullOrWhiteSpace(param.AccessToken) ? $"?access_token={param.AccessToken}" : $"?id_token={param.IdToken}";

            var result = await GetAsync(url).ConfigureAwait(false);
            return m_JsonService.DeserializeObject<ValidateTokenRes>(result);
        }

        /// <summary>
        /// 拼接登出 URL
        /// </summary>
        /// <param name="options">登出参数</param>
        /// <returns></returns>
        public string BuildLogoutUrl(LogoutParams options)
        {
            switch (this.options.Protocol)
            {
                case Protocol.CAS:
                    return BuildCasLogoutUrl(options);
                case Protocol.OIDC:
                    if (options.Expert != null)
                        return BuildOidcLogoutUrl(options);
                    return BuildEasyLogoutUrl(options);
                case Protocol.SAML:
                case Protocol.OAUTH:
                    return BuildEasyLogoutUrl(options);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private string BuildEasyLogoutUrl(LogoutParams options)
        {
            return string.IsNullOrWhiteSpace(options.RedirectUri)
                ? $"{m_BaseUrl}/login/profile/logout"
                : $"{m_BaseUrl}/login/profile/logout?redirect_uri={options.RedirectUri}";
        }

        private string BuildOidcLogoutUrl(LogoutParams options)
        {
            if (string.IsNullOrWhiteSpace(options.RedirectUri) && string.IsNullOrWhiteSpace(options.IdToken) ||
                string.IsNullOrWhiteSpace(options.RedirectUri) || string.IsNullOrWhiteSpace(options.IdToken))
                throw new ArgumentException("必须同时传入 idToken 和 redirectUri 参数，或者同时都不传入");
            return string.IsNullOrWhiteSpace(options.RedirectUri)
                ? $"{m_BaseUrl}/oidc/session/end"
                : $"{m_BaseUrl}/oidc/session/end?id_token_hint={options.IdToken}&post_logout_redirect_uri={options.RedirectUri}";
        }

        private string BuildCasLogoutUrl(LogoutParams options)
        {
            return string.IsNullOrWhiteSpace(options.RedirectUri)
                ? $"{m_BaseUrl}/cas-idp/logout"
                : $"{m_BaseUrl}/cas-idp/logout?url={options.RedirectUri}";
        }

        /// <summary>
        /// Client Credentials 模式获取 Access Token
        /// </summary>
        /// <param name="scope"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public async Task<string> GetAccessTokenByClientCredentials(string scope, GetAccessTokenByClientCredentialsOption options = null)
        {
            if (string.IsNullOrWhiteSpace(scope))
                throw new ArgumentException(
                    "请传入 scope 参数，请看文档：https://docs.authing.cn/v2/guides/authorization/m2m-authz.html");
            if (options is null)
                throw new ArgumentException(
                    "请在调用本方法时传入 { accessKey: string, accessSecret: string }，请看文档：https://docs.authing.cn/v2/guides/authorization/m2m-authz.html");
            var result = await GetAsync(
                "oidc/token",
                new Dictionary<string, string>()
                {
                    {"client_id",$"{options.AccessKey}"},
                    {"client_secret",$"{options.AccessSecret}"},
                    {"grant_type","client_credentials"},
                    {"scope",scope}
                }).ConfigureAwait(false);
            return result;
        }
        /// <summary>
        /// 撤回 Access token 或 Refresh token
        /// </summary>
        /// <param name="token">用户的 Access token 或 Refresh token</param>
        /// <returns></returns>
        public async Task<string> RevokeToken(string token)
        {
            if (options.Protocol != Protocol.OAUTH && options.Protocol != Protocol.OIDC)
                throw new ArgumentException(
                    "初始化 AuthenticationClient 时传入的 protocol 参数必须为 ProtocolEnum.OAUTH 或 ProtocolEnum.OIDC，请检查参数");
            if (string.IsNullOrWhiteSpace(options.AppSecret) &&
                options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.NONE)
                throw new AggregateException("请在初始化 AuthenticationClient 时传入 appId 和 secret 参数");

            var url = options.Protocol == Protocol.OIDC ? "oidc/token/revocation" : "oauth/token/revocation";

            switch (options.TokenEndPointAuthMethod)
            {
                case TokenEndPointAuthMethod.NONE:
                    return await RevokeTokenWithNone(url, token).ConfigureAwait(false);
                case TokenEndPointAuthMethod.CLIENT_SECRET_POST:
                    return await RevokeTokenWithClientSecretPost(url, token).ConfigureAwait(false);
                case TokenEndPointAuthMethod.CLIENT_SECRET_BASIC:
                    return await RevokeTokenWithClientSecretBasic(url, token).ConfigureAwait(false);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private async Task<string> RevokeTokenWithClientSecretPost(string url, string token)
        {
            var result = await GetAsync(
                url,
                new Dictionary<string, string>()
                {
                    {"token",token},
                    {"client_id",options.AppId},
                    {"client_secret",options.AppSecret}
                }).ConfigureAwait(false);
            return result;
        }

        private async Task<string> RevokeTokenWithClientSecretBasic(string url, string token)
        {
            if (options.Protocol == Protocol.OAUTH)
                throw new ArgumentException("OAuth 2.0 暂不支持用 client_secret_basic 模式身份验证撤回 Token");
            var result = await GetAsync(
                "oidc/token/revocation",
                new Dictionary<string, string>()
                {
                    {"token",token}
                }, new Dictionary<string, string>()
                {
                    {
                        "Authorization",
                        $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"{options.AppId}:{options.AppSecret}"))}"
                    }
                }).ConfigureAwait(false);
            return result;
        }

        private async Task<string> RevokeTokenWithNone(string url, string token)
        {
            var result = await GetAsync(
                url,
                new Dictionary<string, string>()
                {
                    {"token",token},
                    {"client_id",options.AppId}
                }).ConfigureAwait(false);
            return result;
        }

        /// <summary>
        /// 检验 CAS 1.0 Ticket 合法性
        /// </summary>
        /// <param name="ticker"></param>
        /// <param name="service"></param>
        /// <returns></returns>
        public async Task<ValidateTicketV1Res> ValidateTicketV1(string ticket, string service)
        {
            var json = await GetAsync($"cas-idp/${m_BaseUrl}/validate/?ticket={ticket}&service={service}").ConfigureAwait(false);

            ValidateTicketV1Response result = m_JsonService.DeserializeObject<ValidateTicketV1Response>(json);

            if (result.Result.Split('\n').Contains("yes"))
            {
                return new ValidateTicketV1Res() { Valid = true };
            }
            else
            {
                return new ValidateTicketV1Res() { Valid = false, Message = "ticket 不合格" };
            }

        }

        /// <summary>
        /// 获取 codechallengedigest
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public string GetCodeChallengeDigest(CodeChallengeDigestOption options)
        {
            if (options.CodeChallenge == null)
            {
                throw new Exception("请提供 options.codeChallenge，值为一个长度大于等于 43 的字符串");
            }
            if (options.Method == CodeChallengeDigestMethod.S256)
            {
                string result = encryptService.SHA256Hash(options.CodeChallenge);
                return result.Replace('+', '-').Replace('/', '_').Replace("=", string.Empty);
            }
            if (options.Method == CodeChallengeDigestMethod.PLAIN)
            {
                return options.CodeChallenge;
            }
            throw new Exception("不支持的 options.method，可选值为 S256、plain");
        }

        /// <summary>
        /// 生成 codechallenge
        /// </summary>
        /// <returns>codechallenge</returns>
        public string GenerateCodeChallenge()
        {
            return stringService.GenerateRandomString(43);
        }

        /// <summary>
        /// 通过远端服务验证票据合法性
        /// </summary>
        /// <param name="ticket"></param>
        /// <param name="service"></param>
        /// <param name="validateTicketFormat"></param>
        /// <returns></returns>
        public async Task<string> ValidateTicketV2(string ticket, string service, ValidateTicketFormat validateTicketFormat)
        {
            var result = await GetAsync($"cas-idp/{options.AppId}/serviceValidate/?ticket={ticket}&service={service}&format={validateTicketFormat}").ConfigureAwait(false);

            return result;
        }

        public async Task<UserInfo> TrackSession()
        {
            var result = await GetAsync("cas/session").ConfigureAwait(false);
            return m_JsonService.DeserializeObject<UserInfo>(result);
        }
    }
}
