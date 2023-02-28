using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.UtilsImpl
{
    public class AKSKService
    {
        public string BuildAuthorization(string accessKeyId, string accessKeySecret, string stringToSign)
        {
            string cryptString = HmacSHA1Signer.SignString(stringToSign, accessKeySecret);
            string auth = $"authing {accessKeyId}:{cryptString}";

            return auth;
        }

        public string GenerateRandomString(int length = 30)
        {
            var rd = new Random((int)DateTime.Now.Ticks);
            var strAtt = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var resAtt = new Char[length];
            rd.Next(0, 62);

            var resStr = string.Join("", resAtt.Select(p => strAtt[rd.Next(0, 62)]).ToArray());
            return resStr;
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

            if (method != "websocket")
            {
                method = method.ToUpper();
            }

            sb.Append(method);
            sb.Append(HEADER_SEPARATOR);
            if (headers != null && headers.Count > 0)
            {
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
            }
            sb.Append(BuildQuerystring(uriPattern, queries));
            return sb.ToString();
        }

        public string BuildCanonicalHeaders(Dictionary<string, string> headers, string headerBegin)
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

        public string[] SplitSubResource(string uri)
        {
            var queIndex = uri.IndexOf("?");
            string[] uriParts;
            uriParts = new string[2];
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

        public string BuildQuerystring(string uri, Dictionary<string, string> queries)
        {
            try
            {
                var uriParts = SplitSubResource(uri);

                if (queries == null)
                {
                    return string.Join("", uriParts);
                }

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
            catch (Exception exp)
            {
                return "";
            }
        }

        public static IDictionary<string, string> SortDictionary(Dictionary<string, string> dic)
        {
            IDictionary<string, string> sortedDictionary =
                new SortedDictionary<string, string>(dic, StringComparer.Ordinal);
            return sortedDictionary;
        }

    }
}
