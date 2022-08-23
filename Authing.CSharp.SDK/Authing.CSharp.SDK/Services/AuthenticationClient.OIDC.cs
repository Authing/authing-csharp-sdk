using Authing.CSharp.SDK.Extensions;
using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Models.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
