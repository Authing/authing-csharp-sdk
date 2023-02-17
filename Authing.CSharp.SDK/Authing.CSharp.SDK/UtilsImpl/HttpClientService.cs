

using Authing.CSharp.SDK.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;

namespace Authing.CSharp.SDK.UtilsImpl
{
    public class HttpClientService : IHttpService
    {
        private static readonly HttpClient m_HttpClient;
        private readonly IJsonService m_JsonService;
        private Dictionary<string, string> m_HeadderDic;
        private string m_BearerToken;
        private readonly IServiceProvider m_ServiceProvider;
        private int timeOut = 10 * 1000;
        private bool rejectUnauthorized = false;

        static HttpClientService()
        {
            ServicePointManager.DefaultConnectionLimit = 1024;
            m_HttpClient = new HttpClient(new HttpClientHandler()
            {
                Proxy = null,
                UseProxy = false,
#if NET48_OR_GREATER
               ServerCertificateCustomValidationCallback = delegate { return true; }
#endif

            });
        }

        public HttpClientService(IJsonService jsonService)
        {
            m_JsonService = jsonService;
            m_HeadderDic = new Dictionary<string, string>();
        }

        public async Task<string> GetAsync(string baseUrl, string apiUrl, Dictionary<string, string> param, CancellationToken cancelllationToken, string bearerToken = null)
        {
            try
            {
                string finalUrl = UrlCombine(baseUrl, apiUrl, param);
                using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, finalUrl))
                {
                    SetWebRequestHeader(request, bearerToken);
                    using (HttpResponseMessage response = await m_HttpClient.SendAsync(request, cancelllationToken).ConfigureAwait(false))
                    {
                        if (!response.IsSuccessStatusCode)
                        {
                            throw new Exception($"代码:{(int)response.StatusCode}");
                        }

                        return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    }
                }
            }
            catch (Exception exp)
            {
                throw new Exception("网络连接超时");
            }
        }

        public async Task<string> PostAsync(string baseUrl, string apiUrl, string json, CancellationToken cancelllationToken, string bearerToken)
        {
            try
            {
                string finalUrl = UrlCombine(baseUrl, apiUrl, null);

                using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, finalUrl)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json"),
                })
                {
                    SetWebRequestHeader(request, bearerToken);

                    using (HttpResponseMessage response = await m_HttpClient.SendAsync(request, cancelllationToken).ConfigureAwait(false))
                    {
                        if (!response.IsSuccessStatusCode)
                        {
                            throw new Exception($"代码:{(int)response.StatusCode}");
                        }

                        return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    }
                }
            }
            catch (TaskCanceledException)
            {
                throw new Exception("网络连接超时");
            }
        }

        public async Task<string> PostAsync(string baseUrl, string apiPath, Dictionary<string, string> param, CancellationToken cancellationToken, string bearerToken = null)
        {
            string json = m_JsonService.SerializeObject(param);

            try
            {
                string finalUrl = UrlCombine(baseUrl, apiPath, null);
                using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, finalUrl)
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json"),
                })
                {
                    SetWebRequestHeader(request, bearerToken);
                    using (HttpResponseMessage response = await m_HttpClient.SendAsync(request, cancellationToken).ConfigureAwait(false))
                    {
                        if (!response.IsSuccessStatusCode)
                        {
                            throw new Exception($"代码:{(int)response.StatusCode}");
                        }

                        return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    }
                }
            }
            catch (TaskCanceledException)
            {
                throw new Exception("网络连接超时");
            }
        }

        public async Task<string> PostFormAsync(string baseUrl, string apiPath, Dictionary<string, string> param, CancellationToken cancellationToken, string bearerToken = null)
        {
            string json = m_JsonService.SerializeObject(param);

            try
            {
                string finalUrl = UrlCombine(baseUrl, apiPath, null);
                using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, finalUrl)
                {
                    Content = new FormUrlEncodedContent(param),
                })
                {
                    SetWebRequestHeader(request, bearerToken);
                    using (HttpResponseMessage response = await m_HttpClient.SendAsync(request, cancellationToken).ConfigureAwait(false))
                    {
                        if (!response.IsSuccessStatusCode)
                        {
                            throw new Exception($"代码:{(int)response.StatusCode}");
                        }

                        return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    }
                }
            }
            catch (TaskCanceledException)
            {
                throw new Exception("网络连接超时");
            }
        }

        public void SetBearerToken(string token)
        {
            throw new NotImplementedException();
        }

        public void ClearHeader()
        {
            m_HeadderDic.Clear();
        }

        public void SetHeader(string key, string value)
        {
            if (m_HeadderDic.ContainsKey(key))
            {
                m_HeadderDic[key] = value;
            }
            else
            {
                m_HeadderDic.Add(key, value);
            }
        }

        private HttpRequestMessage SetWebRequestHeader(HttpRequestMessage request, string bearerToken = null)
        {
            if (!string.IsNullOrWhiteSpace(bearerToken))
            {
                request.Headers.Add("Authorization", $"Bearer {bearerToken}");
            }
            else if (!string.IsNullOrWhiteSpace(m_BearerToken))
            {
                request.Headers.Add("Authorization", $"Bearer {m_BearerToken}");
            }

            foreach (var item in m_HeadderDic)
            {
                if (item.Key == "user-agent")
                {
                    request.Headers.UserAgent.ParseAdd(item.Value);
                    continue;
                }

                    request.Headers.Add(item.Key, item.Value);
            }

            return request;
        }

        private string UrlCombine(string baseUrl, string apiUrl, Dictionary<string, string> param)
        {
            if (string.IsNullOrWhiteSpace(baseUrl))
            {
                baseUrl = string.Empty;
            }
            if (string.IsNullOrWhiteSpace(apiUrl))
            {
                apiUrl = string.Empty;
            }

            baseUrl = baseUrl.TrimEnd('/');
            apiUrl = apiUrl.TrimStart('/');
            string result = baseUrl + "/" + apiUrl;

            if (param is null || param.Count() == 0)
            {
                return result;
            }

            string connector = "?";
            foreach (var x in param)
            {
                result += $"{connector}{x.Key}={x.Value}";
                connector = "&";
            }

            return result;
        }

        public void SetTimeOut(int timeout)
        {
            this.timeOut = timeout;
        }

        public void RejectUnauthorized(bool reject)
        {
            this.rejectUnauthorized = reject;
        }
    }

}



