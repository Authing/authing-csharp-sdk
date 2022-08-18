//using Authing.CSharp.SDK.IServices;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//using System.Net.Http;


//namespace Authing.CSharp.SDK.UtilsImpl
//{
//#if NET45_OR_GREATER
//    public class HttpClienService : IHttpService
//    {
//        private static readonly HttpClient m_HttpClient;
//        private readonly IJsonService m_JsonService;

//        static HttpClienService()
//        {
//            ServicePointManager.DefaultConnectionLimit = 1024;
//            m_HttpClient = new HttpClient(new HttpClientHandler()
//            {
//                Proxy = null,
//                UseProxy = false,
//            });
//        }

//        public HttpClienService(IJsonService jsonService)
//        {
//            m_JsonService = jsonService;
//        }

//        public async Task<string> GetAsync(string baseUrl, string apiUrl, Dictionary<string, string> @params, CancellationToken cancelllationToken, string bearerToken = null)
//        {
//            try
//            {
//                string finalUrl = UrlCombine(baseUrl, apiUrl, @params);
//                using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, finalUrl))
//                using (HttpResponseMessage response = await m_HttpClient.SendAsync(request, cancelllationToken).ConfigureAwait(false))
//                {
//                    if (!response.IsSuccessStatusCode)
//                    {
//                        throw new Exception($"代码:{(int)response.StatusCode}");
//                    }

//                    return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
//                }
//            }
//            catch (TaskCanceledException)
//            {
//                throw new Exception("网络连接超时");
//            }
//        }

//        public Task<string> PostAsync(string baseUrl, string apiUrl, Dictionary<string, object> @params, CancellationToken cancelllationToken, string bearerToken = null)
//        {
//            string paramJson = @params == null ? m_JsonService.SerializeObject(new object()) : m_JsonService.SerializeObject(@params);
//            return PostAsync(baseUrl, apiUrl, paramJson, cancelllationToken);
//        }

//        public async Task<string> PostAsync(string baseUrl, string apiUrl, string json, CancellationToken cancelllationToken, string bearerToken = null)
//        {
//            try
//            {
//                string finalUrl = UrlCombine(baseUrl, apiUrl, null);
//                using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, finalUrl)
//                {
//                    Content = new StringContent(json, Encoding.UTF8, "application/json"),
//                })
//                using (HttpResponseMessage response = await m_HttpClient.SendAsync(request, cancelllationToken).ConfigureAwait(false))
//                {
//                    if (!response.IsSuccessStatusCode)
//                    {
//                        throw new Exception($"代码:{(int)response.StatusCode}");
//                    }

//                    return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
//                }
//            }
//            catch (TaskCanceledException)
//            {
//                throw new Exception("网络连接超时");
//            }
//        }

//        private string UrlCombine(string baseUrl, string apiUrl, Dictionary<string, string> param)
//        {
//            if (string.IsNullOrWhiteSpace(baseUrl))
//            {
//                baseUrl = string.Empty;
//            }
//            if (string.IsNullOrWhiteSpace(apiUrl))
//            {
//                apiUrl = string.Empty;
//            }

//            baseUrl = baseUrl.TrimEnd('/');
//            apiUrl = apiUrl.TrimStart('/');
//            string result = baseUrl + "/" + apiUrl;

//            if (param is null || param.Count() == 0)
//            {
//                return result;
//            }

//            string connector = "?";
//            foreach (var x in param)
//            {
//                result += $"{connector}{x.Key}={x.Value}";
//                connector = "&";
//            }

//            return result;
//        }
//    }

//#endif

//}

