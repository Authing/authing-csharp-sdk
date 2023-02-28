using Authing.CSharp.SDK.Models.Authentication;
using Authing.CSharp.SDK.Utils;
using Authing.CSharp.SDK.Utils.Extensions;
using Authing.CSharp.SDK.UtilsImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace Authing.CSharp.SDK.Services
{
    public class BaseAuthenticationService : ServiceBase
    {
        protected readonly string m_AppHost;

        protected readonly string m_AppId;
        private bool needBase64 = false;
        private AuthenticationClientInitOptions options;
        private string m_WebsocketUri;

        protected Dictionary<string, WebSocket> websocketDic;
        protected Dictionary<string, Action<string>> messageCallbackDic;
        protected Dictionary<string, Action<string>> errorCallbackDic;



        public BaseAuthenticationService(AuthenticationClientInitOptions options) : base(new JsonService(),new DateTimeService())
        {
            this.options = options;
            m_AppHost = options.AppHost;

            m_WebsocketUri = options.WebsocketUri;
            if (!string.IsNullOrWhiteSpace(m_WebsocketUri))
            {
                websocketDic = new Dictionary<string, WebSocket>();
                messageCallbackDic = new Dictionary<string, Action<string>>();
                errorCallbackDic = new Dictionary<string, Action<string>>();
            }
        }
        protected void BaseSub(string eventName , Action<string> messageCallback, Action<string> errorCallback)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(m_WebsocketUri))
                {
                    throw new Exception("Websocket 连接地址不能为空");
                }

                if (string.IsNullOrWhiteSpace(eventName))
                {
                    throw new Exception("订阅事件不能为空");
                }

                if (websocketDic == null)
                {
                    websocketDic = new Dictionary<string, WebSocket>();
                }

                if (websocketDic.ContainsKey(eventName))
                {
                    throw new Exception("已经对该事件添加订阅");
                }

                if (!messageCallbackDic.ContainsKey(eventName))
                {
                    messageCallbackDic.Add(eventName, messageCallback);
                }

                if (!errorCallbackDic.ContainsKey(eventName))
                {
                    errorCallbackDic.Add(eventName, errorCallback);
                }

                Dictionary<string, string> headers = new Dictionary<string, string>();
               
                var ws = new WebSocket($"{m_WebsocketUri}/events/v1/authentication/sub?code={eventName}&token={options.AccessToken}");

                websocketDic.Add(eventName, ws);

                websocketDic[eventName].OnOpen += (sender, e) =>
                {
                };
                websocketDic[eventName].OnMessage += (sender, e) =>
                {
                    messageCallbackDic[eventName].Invoke(m_JsonService.SerializeObject(e.Data));
                };
                websocketDic[eventName].OnClose += (sender, e) =>
                {
                    errorCallbackDic[eventName]?.Invoke(e.Reason);
                };
                websocketDic[eventName].OnError += (sender, e) =>
                {
                    errorCallbackDic[eventName]?.Invoke(e.Message);
                    websocketDic[eventName].Connect();
                };

                websocketDic[eventName].Connect();



            }
            catch (Exception exp)
            {
                throw exp;
            }
        }

        protected async Task<string> GetAsync(string apiPath)
        {
            SetHeaders();

            string httpResponse = await m_HttpService.GetAsync(options.AppHost, apiPath, default, default).ConfigureAwait(false);
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

            string httpResponse = await m_HttpService.GetAsync(options.AppHost, apiPath, dic, default).ConfigureAwait(false);
            return httpResponse;
        }

        protected async Task<string> GetAsync(string apiPath, Dictionary<string, string> dics, string accessToken)
        {
            m_HttpService.SetBearerToken(accessToken);

            SetHeaders();

            string httpResponse = await m_HttpService.GetAsync(options.AppHost, apiPath, dics, default).ConfigureAwait(false);
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

            string httpResponse = await m_HttpService.GetAsync(options.AppHost, apiPath, dic, default).ConfigureAwait(false);
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

            string httpResponse = await m_HttpService.PostAsync(options.AppHost, apiPath, jsonParam, default).ConfigureAwait(false);
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

            string httpResponse = await m_HttpService.PostAsync(options.AppHost, apiPath, jsonParam, default).ConfigureAwait(false);
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

            string httpResponse = await m_HttpService.PostFormAsync(options.AppHost, apiPath, dic, default).ConfigureAwait(false);
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

            string httpResponse = await m_HttpService.PostFormAsync(options.AppHost, apiPath, dic, default).ConfigureAwait(false);
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
            //string defaultUA = $"AuthingIdentityCloud ({Environment.OSVersion.VersionString}; {osBit}) doNet(v{Environment.Version}), authing-csharp-sdk:{System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}";
            string defaultUA = $"AuthingIdentityCloud ({Environment.OSVersion.VersionString}; {osBit})";

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
