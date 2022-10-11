using Authing.CSharp.SDK.Extensions;
using Authing.CSharp.SDK.Models.Management;
using Authing.CSharp.SDK.Utils;
using Authing.CSharp.SDK.Utils.Extensions;
using Authing.CSharp.SDK.UtilsImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Services
{
    public abstract class BaseManagementService : ServiceBase
    {
        protected readonly string m_UserPoolId;
        protected readonly string m_Secret;

        protected GetManagementTokenRespDto m_TokenInfo;

        protected readonly string m_BaseUrl;

        protected ClientLang clientLang;

        public BaseManagementService(ManagementClientOptions options) : base(new JsonService())
        {
            m_UserPoolId = options.AccessKeyId;
            m_Secret = options.AccessKeySecret;

            m_BaseUrl = options.Host;

            if (!string.IsNullOrWhiteSpace(options.Host))
            {
                m_BaseUrl = options.Host;
            }

            clientLang = options.Lang;

        }

        protected async Task<string> PostAsync(string apiPath, string param)
        {
            await CheckToken("POST",apiPath, m_JsonService.DeserializeObject<Dictionary<string, string>>(param));

            string httpResponse = await m_HttpService.PostAsync(m_BaseUrl, apiPath, param, default).ConfigureAwait(false);
            return httpResponse;
        }


        protected async Task<string> Request(string method, string apiPath, Dictionary<string, object> pairs, bool withToken = true)
        {
            Dictionary<string, string> dic = pairs.ToDictionary((keyItem) => keyItem.Key, (valueItem) => valueItem.Value == null ? "" : valueItem.Value.ToString());
            await CheckToken(method,apiPath, dic).ConfigureAwait(false);

            string httpResponse = await m_HttpService.GetAsync(m_BaseUrl, apiPath, dic, default).ConfigureAwait(false);
            return httpResponse;
        }

        protected async Task<string> Request(string method, string apiPath, bool withToken = true)
        {
            return "";
        }

        protected async Task<string> Request<T>(string method, string apiPath, T dto, bool withToken = true)
        {
            Dictionary<string, object> dic = m_JsonService.DeserializeObject<Dictionary<string, object>>(m_JsonService.SerializeObjectIngoreNull(dto));

           var stringDic= dic.ToDictionary(p => p.Key, p=>m_JsonService.SerializeObject(p.Value));


            await CheckToken(method,apiPath, stringDic).ConfigureAwait(false);


            string json = m_JsonService.SerializeObjectIngoreNull(dto);

            string httpResponse = await m_HttpService.PostAsync(m_BaseUrl, apiPath, json, default).ConfigureAwait(false);
            return httpResponse;
        }



        private async Task CheckToken(string method,string apiPath, Dictionary<string, string> queries)
        {
            m_HttpService.ClearHeader();

            //组装、 加密 
            //设置头
            DateTime utcTime = DateTime.Now;
            string osBit = Environment.Is64BitOperatingSystem ? "x64" : "x86";
            string defaultUA = $"AuthingIdentityCloud ({Environment.OSVersion.VersionString}; {osBit}) .Net(v{Environment.Version}), authing-csharp-sdk:{System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}";

            m_HttpService.SetHeader("x-authing-signature-nonce", "131231adadad");
            m_HttpService.SetHeader("x-authing-signature-method", "HMAC-SHA1");
            m_HttpService.SetHeader("x-authing-signature-version", "1.0");
            //m_HttpService.SetHeader("user-agent", defaultUA);
            m_HttpService.SetHeader("x-authing-sdk-version", "authing-csharp-sdk:0.0.4");
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
            dics.Add("x-authing-signature-nonce", "131231adadad");
            dics.Add("x-authing-signature-method", "HMAC-SHA1");
            dics.Add("x-authing-signature-version", "1.0");
            //dics.Add("user-agent", defaultUA);
            dics.Add("x-authing-sdk-version", "authing-csharp-sdk:0.0.4");
            dics.Add("x-authing-date", utcTime.ToString());

            string result = ComposeStringToSign(method,apiPath, queries, dics);

            string cryptString = HmacSHA1Signer.SignString(result, m_Secret);

            m_HttpService.SetHeader("authorization", $"authing {m_UserPoolId}:{cryptString}");
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
        public string ComposeStringToSign(string method,string uriPattern, Dictionary<string, string> queries, Dictionary<string, string> headers)
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
                sb.Append("x-authing-sdk-version:"+headers["x-authing-sdk-version"]);
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



        private async Task GetManagementToken(CancellationToken cancellationToken)
        {
            GetManagementAccessTokenDto dto = new GetManagementAccessTokenDto()
            {
                AccessKeyId = m_UserPoolId,
                AccessKeySecret = m_Secret
            };

            string json = BuildHttpPostRequest(dto);

            string httpResponse = await m_HttpService.PostAsync(m_BaseUrl, "/api/v3/get-management-token", json, cancellationToken).ConfigureAwait(false);

            GetManagementTokenRespDto result = m_JsonService.DeserializeObject<GetManagementTokenRespDto>(httpResponse);

            m_TokenInfo = result;

        }
    }
}
