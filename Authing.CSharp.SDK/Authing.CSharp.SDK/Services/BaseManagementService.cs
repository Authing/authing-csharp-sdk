using Authing.CSharp.SDK.Extensions;
using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Utils;
using Authing.CSharp.SDK.Utils.Extensions;
using Authing.CSharp.SDK.UtilsImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using WebSocketSharp;

namespace Authing.CSharp.SDK.Services
{
    public abstract class BaseManagementService : ServiceBase
    {
        protected readonly string m_UserPoolId;
        protected readonly string m_Secret;

        protected readonly string m_WebsocketUri;

        protected GetManagementTokenRespDto m_TokenInfo;

        protected readonly string m_BaseUrl;

        protected ClientLang clientLang;

        protected IDateTimeService m_DatetimeService;
        protected AKSKService m_AKSKService;

        protected Dictionary<string, WebSocket> websocketDic;

        protected Dictionary<string, Action<string>> messageCallbackDic;
        protected Dictionary<string, Action<string>> errorCallbackDic;

        public BaseManagementService(ManagementClientOptions options) : base(new JsonService(), new DateTimeService())
        {
            m_UserPoolId = options.AccessKeyId;
            m_Secret = options.AccessKeySecret;

            m_BaseUrl = options.Host;

            if (!string.IsNullOrWhiteSpace(options.Host))
            {
                m_BaseUrl = options.Host;
            }

            clientLang = options.Lang;

            m_DatetimeService = new DateTimeService();
            m_AKSKService = new AKSKService();

            m_WebsocketUri = options.WebsocketUri;

            if (!string.IsNullOrWhiteSpace(m_WebsocketUri))
            {
                websocketDic = new Dictionary<string, WebSocket>();
                messageCallbackDic = new Dictionary<string, Action<string>>();
                errorCallbackDic = new Dictionary<string, Action<string>>();
            }

        }

        protected void BaseSub(string eventName, Action<string> messageCallback, Action<string> errorCallback)
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
                string authorization = m_AKSKService.BuildAuthorization(m_UserPoolId, m_Secret, m_AKSKService.ComposeStringToSign("websocket", "", null, null));

                var ws = new WebSocket($"{m_WebsocketUri}/events/v1/management/sub?code={eventName}");

                websocketDic.Add(eventName, ws);
                websocketDic[eventName].CustomHeaders = new Dictionary<string, string>() { { "Authorization", authorization } };
                websocketDic[eventName].OnOpen += (sender, e) =>
                {
                    messageCallbackDic[eventName].Invoke("连接成功");
                };
                websocketDic[eventName].OnMessage += (sender, e) =>
                {
                    messageCallbackDic[eventName].Invoke(m_JsonService.SerializeObject(e.Data));
                };
                websocketDic[eventName].OnClose += (sender, e) =>
                {
                    messageCallbackDic[eventName].Invoke("连接关闭"+e.Reason);
                };
                websocketDic[eventName].OnError += (sender, e) =>
                {
                    messageCallbackDic[eventName].Invoke("连接发生错误"+e.Message);
                    websocketDic[eventName].Connect();
                };

                websocketDic[eventName].Connect();



            }
            catch (Exception exp)
            {

            }
        }

        private void BaseManagementService_OnOpen(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BaseManagementService_OnClose(object sender, CloseEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void HandleWebsocketConnection()
        {

        }

        protected void HandleWebsocketDisconnect()
        { }

        protected void HandleWebsocketError()
        {

        }

        protected async Task<string> PostAsync(string apiPath, string param)
        {
            CheckToken("POST", apiPath, m_JsonService.DeserializeObject<Dictionary<string, string>>(param));

            string httpResponse = await m_HttpService.PostAsync(m_BaseUrl, apiPath, param, default).ConfigureAwait(false);
            return httpResponse;
        }


        protected async Task<string> GetAsync<T>(string method, string apiPath, T dto)
        {
            Dictionary<string, string> dic = m_JsonService.DeserializeObject<Dictionary<string, string>>(m_JsonService.SerializeObjectIngoreNull(dto));

            CheckToken(method, apiPath, dic);

            string httpResponse = await m_HttpService.GetAsync(m_BaseUrl, apiPath, dic, default).ConfigureAwait(false);
            return httpResponse;
        }

        protected async Task<string> Request(string method, string apiPath)
        {
            CheckToken(method, apiPath, new Dictionary<string, string> { });

            string httpResponse = await m_HttpService.GetAsync(m_BaseUrl, apiPath, null, default);
            return httpResponse;
        }

        protected async Task<string> Request<T>(string method, string apiPath, T dto)
        {
            if (method == "POST")
            {
                return await PostAsync(method, apiPath, dto);
            }
            else
            {
                return await GetAsync(method, apiPath, dto);
            }
        }

        protected async Task<string> PostAsync<T>(string method, string apiPath, T dto)
        {
            Dictionary<string, object> dic = m_JsonService.DeserializeObject<Dictionary<string, object>>(m_JsonService.SerializeObjectIngoreNull(dto));

            var stringDic = dic.ToDictionary(p => p.Key, p =>
            {
                if (p.Value.GetType().Name == "String")
                {
                    return p.Value.ToString();
                }
                else
                {
                    return m_JsonService.SerializeObject(p.Value);
                }
            });


            CheckToken(method, apiPath, stringDic);


            string json = m_JsonService.SerializeObjectIngoreNull(dic);

            string httpResponse = await m_HttpService.PostAsync(m_BaseUrl, apiPath, json, default).ConfigureAwait(false);
            return httpResponse;
        }



        private void CheckToken(string method, string apiPath, Dictionary<string, string> queries)
        {
            m_HttpService.ClearHeader();

            //组装、 加密 
            //设置头
            long utcTime = m_DatetimeService.DateTimeNowToTimestamp();
            string osBit = Environment.Is64BitOperatingSystem ? "x64" : "x86";
            //string defaultUA = $"AuthingIdentityCloud ({Environment.OSVersion.VersionString}; {osBit}) .Net(v{Environment.Version}), authing-csharp-sdk:{System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}";
            string defaultUA = $"AuthingIdentityCloud ({Environment.OSVersion.VersionString}; {osBit}) doNet";
            string version = $"authing-csharp-sdk:{System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}";
            string nonce = m_AKSKService.GenerateRandomString();

            m_HttpService.SetHeader("x-authing-signature-nonce", nonce);
            m_HttpService.SetHeader("x-authing-signature-method", "HMAC-SHA1");
            m_HttpService.SetHeader("x-authing-signature-version", "1.0");
            m_HttpService.SetHeader("user-agent", defaultUA);
            m_HttpService.SetHeader("x-authing-sdk-version", version);
            m_HttpService.SetHeader("x-authing-date", utcTime.ToString());
            /*
             const DEFAULT_UA =
  `AuthingIdentityCloud (${os.platform()}; ${os.arch()}) ` +
  `Node.js/${process.version} Core/${pkg.version}`;
const DEFAULT_CLIENT = `Node.js(${process.version}), ${pkg.name}: ${pkg.version}`;
            AuthingIdentityCloud (linux; x64) Node.js/v14.18.0 Core/0.0.19
Node.js(v14.18.0), authing-node-sdk: 0.0.19
             */
            Dictionary<string, string> dics = new Dictionary<string, string>();
            dics.Add("content-type", "application/json");
            dics.Add("x-authing-signature-nonce", nonce);
            dics.Add("x-authing-signature-method", "HMAC-SHA1");
            dics.Add("x-authing-signature-version", "1.0");
            dics.Add("user-agent", defaultUA);
            dics.Add("x-authing-sdk-version", version);
            dics.Add("x-authing-date", utcTime.ToString());

            string result = m_AKSKService.ComposeStringToSign(method, apiPath, queries, dics);

            string cryptString = HmacSHA1Signer.SignString(result, m_Secret);

            m_HttpService.SetHeader("authorization", $"authing {m_UserPoolId}:{cryptString}");
        }

      
    }

    public static class Event
    {
        public static readonly string CONNECTION = "connection";
        public static readonly string DISCONNECT = "disconnect";
        public static readonly string ERROR = "error";
    }
}
