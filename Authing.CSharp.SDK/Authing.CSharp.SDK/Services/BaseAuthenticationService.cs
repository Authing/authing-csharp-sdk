using Authing.CSharp.SDK.Models.Authentication;
using Authing.CSharp.SDK.Utils;
using Authing.CSharp.SDK.Utils.Extensions;
using Authing.CSharp.SDK.UtilsImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Services
{
    public class BaseAuthenticationService : ServiceBase
    {
        /// <summary>
        /// 控制台 Host
        /// </summary>
        protected readonly string m_Host;

        /// <summary>
        /// App Host
        /// </summary>
        protected readonly string m_AppHost;


        protected readonly string m_AppId;
        private string accessToken;
        private bool needBase64 = false;
        private AuthenticationClientInitOptions options;

        public BaseAuthenticationService(AuthenticationClientInitOptions options) : base(new JsonService())
        {
            m_AppHost = options.AppHost;

            m_Host = ConfigService.BASE_URL;

            if (!string.IsNullOrWhiteSpace(options.Host))
            {
                m_Host = options.Host;
            }

            this.options = options;
        }

        protected async Task<string> GetAsync(string apiPath)
        {
            SetHeaders();

            string httpResponse = await m_HttpService.GetAsync(m_Host, apiPath, default, default).ConfigureAwait(false);
            return httpResponse;
        }

        protected async Task<string> GetWithHostAsync(string host, string apiPath, Dictionary<string, string> headers = default, Dictionary<string, string> param = default)
        {
            SetHeaders(headers);

            string httpResponse = await m_HttpService.GetAsync(host, apiPath, param, default).ConfigureAwait(false);
            return httpResponse;
        }

        protected async Task<string> GetAsync(string apiPath, string param)
        {
            SetHeaders();

            var dic = m_JsonService.DeserializeObject<Dictionary<string, string>>(param);

            string httpResponse = await m_HttpService.GetAsync(m_Host, apiPath, dic, default).ConfigureAwait(false);
            return httpResponse;
        }

        protected async Task<string> GetAsync(string apiPath, Dictionary<string, string> dics, string accessToken)
        {
            m_HttpService.SetBearerToken(accessToken);

            SetHeaders();

            string httpResponse = await m_HttpService.GetAsync(m_Host, apiPath, dics, default).ConfigureAwait(false);
            return httpResponse;
        }

        protected async Task<string> GetAsync(string apiPath, string param, string accessToken)
        {
            if (string.IsNullOrWhiteSpace(param))
            {
                param = "";
            }

            var dic = m_JsonService.DeserializeObject<Dictionary<string, string>>(param);

            m_HttpService.SetBearerToken(accessToken);

            SetHeaders();

            string httpResponse = await m_HttpService.GetAsync(m_Host, apiPath, dic, default).ConfigureAwait(false);
            return httpResponse;
        }

        /// <summary>
        /// Post 方法
        /// </summary>
        /// <param name="apiPath"></param>
        /// <param name="jsonParam"></param>
        /// <param name="accessToken">登录成功后，返回的 AccessToken </param>
        /// <returns></returns>
        protected async Task<string> PostAsync(string apiPath, string jsonParam, string accessToken)
        {
            m_HttpService.SetBearerToken(accessToken);

            SetHeaders();

            string httpResponse = await m_HttpService.PostAsync(m_Host, apiPath, jsonParam, default).ConfigureAwait(false);
            return httpResponse;
        }

        /// <summary>
        /// Json 参数的请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="apiPath"></param>
        /// <param name="jsonParam"></param>
        /// <param name="headers"></param>
        /// <returns></returns>
        protected async Task<string> PostAsync(string apiPath, string jsonParam, Dictionary<string, string> headers = null)
        {
            SetHeaders(headers);

            string httpResponse = await m_HttpService.PostAsync(m_Host, apiPath, jsonParam, default).ConfigureAwait(false);
            return httpResponse;
        }

        /// <summary>
        /// Json 参数的请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="apiPath"></param>
        /// <param name="jsonParam"></param>
        /// <param name="headers"></param>
        /// <returns></returns>
        protected async Task<string> PostWithHostAsync(string host,string apiPath, Dictionary<string,string> jsonParam, Dictionary<string, string> headers = null)
        {
            SetHeaders(headers);

            string httpResponse = await m_HttpService.PostAsync(host, apiPath, jsonParam, default).ConfigureAwait(false);
            return httpResponse;
        }

        /// <summary>
        /// 表单请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="apiPath"></param>
        /// <param name="dto"></param>
        /// <param name="headers"></param>
        /// <returns></returns>
        protected async Task<string> PostFormAsync<T>(string apiPath, T dto, Dictionary<string, string> headers = null)
        {
            string json = m_JsonService.SerializeObject(dto);
            Dictionary<string, string> dic = m_JsonService.DeserializeObject<Dictionary<string, string>>(json);

            SetHeaders(headers);

            string httpResponse = await m_HttpService.PostFormAsync(m_Host, apiPath, dic, default).ConfigureAwait(false);
            return httpResponse;
        }

        /// <summary>
        /// 表单请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="apiPath"></param>
        /// <param name="dto"></param>
        /// <param name="headers"></param>
        /// <returns></returns>
        protected async Task<string> PostFormAsyncWithHost<T>(string host, string apiPath, T dto, Dictionary<string, string> headers = null)
        {
            string json = m_JsonService.SerializeObject(dto);
            Dictionary<string, string> dic = m_JsonService.DeserializeObject<Dictionary<string, string>>(json);

            SetHeaders(headers);

            string httpResponse = await m_HttpService.PostFormAsync(host, apiPath, dic, default).ConfigureAwait(false);
            return httpResponse;
        }

        /// <summary>
        /// 表单请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="apiPath"></param>
        /// <param name="dto"></param>
        /// <param name="accesstoken"></param>
        /// <param name="headers"></param>
        /// <returns></returns>
        protected async Task<string> PostFormAsync<T>(string apiPath, T dto, string accesstoken, Dictionary<string, string> headers = null)
        {
            string json = m_JsonService.SerializeObject(dto);
            Dictionary<string, string> dic = m_JsonService.DeserializeObject<Dictionary<string, string>>(json);

            if (!string.IsNullOrWhiteSpace(accesstoken))
            {
                m_HttpService.SetBearerToken(accesstoken);
            }
            SetHeaders(headers);

            string httpResponse = await m_HttpService.PostFormAsync(m_Host, apiPath, dic, default).ConfigureAwait(false);
            return httpResponse;
        }

        private List<string> endPointToSendBasicHeader = new List<string>
                                                             {
                                                              "/oidc/token",
                                                              "/oidc/token/revocation",
                                                              "/oidc/token/introspection",
                                                              "/oauth/token",
                                                              "/oauth/token/revocation",
                                                              "/oauth/token/introspection",
                                                              "/api/v3/signin",
                                                              "/api/v3/signin-by-mobile",
                                                              "/api/v3/exchange-tokenset-with-qrcode-ticket"
                                                            };

        private void NeedBase64(string apiPath)
        {
            if (options.TokenEndPointAuthMethod == Models.TokenEndPointAuthMethod.CLIENT_SECRET_BASIC && endPointToSendBasicHeader.Contains(apiPath))
            {
                needBase64 = true;
            }
            else
            {
                needBase64 = false;
            }
        }

        protected void SetHeaders(Dictionary<string, string> headers = null)
        {
            m_HttpService.ClearHeader();

            if (headers != null)
            {
                foreach (var item in headers)
                {
                    m_HttpService.SetHeader(item.Key, item.Value);
                }
            }

            if (!string.IsNullOrWhiteSpace(options.AccessToken))
            {
                if (needBase64)
                {
                    byte[] bytes = Encoding.UTF8.GetBytes($"{options.AppId}:{options.AppSecret}");

                    string token = "Basic " + Convert.ToBase64String(bytes);
                    m_HttpService.SetBearerToken(token);
                }
                else
                {
                    m_HttpService.SetBearerToken(options.AccessToken);
                }
            }

            string osBit = Environment.Is64BitOperatingSystem ? "x64" : "x86";
            string version = $"authing-csharp-sdk:{System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}";
            string defaultUA = $"AuthingIdentityCloud ({Environment.OSVersion.VersionString}; {osBit}) .Net(v{Environment.Version}), authing-csharp-sdk:{System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}";

            m_HttpService.SetHeader("x-authing-sdk-version", version);
            m_HttpService.SetHeader("x-authing-app-id", options.AppId);
            m_HttpService.SetHeader("x-authing-lang", options.Lang.GetDescription());
            m_HttpService.SetHeader("user-agent", defaultUA);


            m_HttpService.SetTimeOut(options.TimeOut);
            m_HttpService.RejectUnauthorized(options.rejectUnauthorized);

        }

        protected async Task<string> Request<T>(string method, string apiPath, T dto)
        {
            NeedBase64(apiPath);
            if (method == "GET")
            {
                var res = await GetAsync(apiPath, m_JsonService.SerializeObjectIngoreNull(dto)).ConfigureAwait(false);
                return res;
            }
            else
            {
                var res = await PostAsync(apiPath, m_JsonService.SerializeObjectIngoreNull(dto)).ConfigureAwait(false);
                return res;
            }
        }

        protected async Task<string> Request(string method, string apiPath)
        {
            NeedBase64(apiPath);
            if (method == "GET")
            {
                return await GetAsync(apiPath).ConfigureAwait(false);
            }
            if (method == "POST")
            {
                return await PostAsync(apiPath,"").ConfigureAwait(false);
            }
            return "";
        }
    }
}
