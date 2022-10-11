using Authing.CSharp.SDK.Models.Authentication;
using Authing.CSharp.SDK.Utils;
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

        public BaseAuthenticationService(AuthenticationClientInitOptions options) : base(new JsonService())
        {
            m_AppHost = options.AppHost;

            m_Host = ConfigService.BASE_URL;

            if (!string.IsNullOrWhiteSpace(options.Host))
            {
                m_Host = options.Host;
            }

            m_AppId = options.AppId;
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

        protected async Task<string> Request<T>(string method, string apiPath, T dto)
        {
            if (method == "Get")
            {
                return await GetAsync(apiPath, m_JsonService.SerializeObjectIngoreNull(dto)).ConfigureAwait(false);
            }
            else
            {
                return await PostAsync(apiPath, m_JsonService.SerializeObjectIngoreNull(dto)).ConfigureAwait(false);
            }
        }

        protected async Task<string> Request(string method, string apiPath)
        {
            if (method == "Get")
            {
                return await GetAsync(apiPath).ConfigureAwait(false);
            }
            return "";
        }





        protected const string QUERY_SEPARATOR = "&";
        protected const string HEADER_SEPARATOR = "\n";

        /// <summary>
        /// 组装 Header
        /// </summary>
        /// <param name="uriPattern">api 路径</param>
        /// <param name="queries">参数</param>
        /// <param name="headers">头信息</param>
        /// <returns></returns>
        public string ComposeStringToSign(string method, string uriPattern, Dictionary<string, string> queries, Dictionary<string, string> headers)
        {
            var sb = new StringBuilder();

            sb.Append(method.ToUpper());

            sb.Append(HEADER_SEPARATOR);
            if (headers.ContainsKey("x-authing-date"))
            {
                sb.Append("x-authing-date:" + headers["x-authing-date"]);
            }

            sb.Append(HEADER_SEPARATOR);
            if (headers.ContainsKey("x-authing-sdk-version"))
            {
                sb.Append("x-authing-sdk-version:" + headers["x-authing-sdk-version"]);
            }

            sb.Append(HEADER_SEPARATOR);
            if (headers.ContainsKey("x-authing-signature-method"))
            {
                sb.Append("x-authing-signature-method:" + headers["x-authing-signature-method"]);
            }

            sb.Append(HEADER_SEPARATOR);
            if (headers.ContainsKey("x-authing-signature-nonce"))
            {
                sb.Append("x-authing-signature-nonce:" + headers["x-authing-signature-nonce"]);
            }

            sb.Append(HEADER_SEPARATOR);
            if (headers.ContainsKey("x-authing-signature-version"))
            {
                sb.Append("x-authing-signature-version:" + headers["x-authing-signature-version"]);
            }

            sb.Append(HEADER_SEPARATOR);
            //sb.Append(BuildCanonicalHeaders(headers, "x-authing-"));
            sb.Append(BuildQuerystring(uriPattern, queries));
            return sb.ToString();
        }

        protected string BuildCanonicalHeaders(Dictionary<string, string> headers, string headerBegin)
        {
            var sortMap = new Dictionary<string, string>();
            foreach (var e in headers)
            {
                var key = e.Key.ToLower();
                var val = e.Value;
                if (key.StartsWith(headerBegin))
                {
                    sortMap.Add(key, val);
                }
            }

            var sortedDictionary = SortDictionary(sortMap);

            var headerBuilder = new StringBuilder();
            foreach (var e in sortedDictionary)
            {
                headerBuilder.Append(e.Key);
                headerBuilder.Append(':').Append(e.Value);
                headerBuilder.Append(HEADER_SEPARATOR);
            }

            return headerBuilder.ToString();
        }

        public static string ReplaceOccupiedParameters(string url, Dictionary<string, string> paths)
        {
            var result = url;
            foreach (var entry in paths)
            {
                var key = entry.Key;
                var value = entry.Value;
                var target = "[" + key + "]";
                result = result.Replace(target, value);
            }

            return result;
        }

        private string[] SplitSubResource(string uri)
        {
            var queIndex = uri.IndexOf("?");
            var uriParts = new string[2];
            if (-1 != queIndex)
            {
                uriParts[0] = uri.Substring(0, queIndex);
                uriParts[1] = uri.Substring(queIndex + 1);
            }
            else
            {
                uriParts[0] = uri;
            }

            return uriParts;
        }

        private string BuildQuerystring(string uri, Dictionary<string, string> queries)
        {
            var uriParts = SplitSubResource(uri);
            var sortMap = new Dictionary<string, string>(queries);
            if (null != uriParts[1])
            {
                sortMap.Add(uriParts[1], null);
            }

            var queryBuilder = new StringBuilder(uriParts[0]);
            var sortedDictionary = SortDictionary(sortMap);
            if (0 < sortedDictionary.Count)
            {
                queryBuilder.Append("?");
            }

            foreach (var e in sortedDictionary)
            {
                queryBuilder.Append(e.Key);
                if (null != e.Value)
                {
                    queryBuilder.Append("=").Append(e.Value);
                }

                queryBuilder.Append(QUERY_SEPARATOR);
            }

            var querystring = queryBuilder.ToString();
            if (querystring.EndsWith(QUERY_SEPARATOR))
            {
                querystring = querystring.Substring(0, querystring.Length - 1);
            }

            return querystring;
        }

        private static IDictionary<string, string> SortDictionary(Dictionary<string, string> dic)
        {
            IDictionary<string, string> sortedDictionary =
                new SortedDictionary<string, string>(dic, StringComparer.Ordinal);
            return sortedDictionary;
        }
    }
}
