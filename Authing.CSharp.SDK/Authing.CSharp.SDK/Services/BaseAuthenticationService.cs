using Authing.CSharp.SDK.Models.Authentication;
using Authing.CSharp.SDK.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Services
{
    public class BaseAuthenticationService : ServiceBase
    {
        protected readonly string m_BaseUrl;

        protected readonly string m_AppId;

        public BaseAuthenticationService(AuthenticationClientInitOptions options) : base(new JsonService())
        {
            m_BaseUrl = ConfigService.BASE_URL;

            if (!string.IsNullOrWhiteSpace(options.Host))
            {
                m_BaseUrl = options.Host;
            }

            m_AppId = options.AppId;
        }

        protected async Task<string> GetAsync(string apiPath)
        {
            string httpResponse = await m_HttpService.GetAsync(m_BaseUrl, apiPath, default, default).ConfigureAwait(false);
            return httpResponse;
        }

        protected async Task<string> GetAsync(string apiPath, string param)
        {
            var dic = m_JsonService.DeserializeObject<Dictionary<string, string>>(param);

            string httpResponse = await m_HttpService.GetAsync(m_BaseUrl, apiPath, dic, default).ConfigureAwait(false);
            return httpResponse;
        }

        protected async Task<string> GetAsync(string apiPath, Dictionary<string, string> dics,Dictionary<string,string> headers=null)
        {
            SetHeaders(headers);

            string httpResponse = await m_HttpService.GetAsync(m_BaseUrl, apiPath, dics,default).ConfigureAwait(false);
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

            string httpResponse = await m_HttpService.GetAsync(m_BaseUrl, apiPath, dic, default).ConfigureAwait(false);
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

            string httpResponse = await m_HttpService.PostAsync(m_BaseUrl, apiPath, jsonParam, default).ConfigureAwait(false);
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

            string httpResponse = await m_HttpService.PostAsync(m_BaseUrl, apiPath, jsonParam, default).ConfigureAwait(false);
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

            string httpResponse = await m_HttpService.PostAsync(m_BaseUrl, apiPath, dic, default).ConfigureAwait(false);
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

            m_HttpService.SetBearerToken(accesstoken);
            SetHeaders(headers);

            string httpResponse = await m_HttpService.PostAsync(m_BaseUrl, apiPath, dic, default).ConfigureAwait(false);
            return httpResponse;
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

            m_HttpService.SetHeader("x-authing-request-from", "SDK");
            m_HttpService.SetHeader("x-authing-sdk-version", "c-sharp:5.0.0");
            m_HttpService.SetHeader("x-authing-app-id", m_AppId);
        }
    }
}
