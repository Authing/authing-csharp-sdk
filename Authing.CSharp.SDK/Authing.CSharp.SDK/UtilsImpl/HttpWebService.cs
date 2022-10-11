using Authing.CSharp.SDK.IServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Utils
{
    public class HttpWebService : IHttpService
    {
        private string m_BearerToken;
        private Dictionary<string, string> m_HeadderDic;
        private IJsonService m_JsonService;

        private int timeOut = 10 * 1000;
        private bool rejectUnauthorized = false;

        public HttpWebService(IJsonService jsonService)
        {
            m_HeadderDic = new Dictionary<string, string>();
            m_JsonService = jsonService;
        }

        public async Task<string> GetAsync(string baseUrl, string apiPath, Dictionary<string, string> param, CancellationToken cancellationToken, string bearerToken = null)
        {
            try
            {
                if (!rejectUnauthorized)
                {
                    ServicePointManager.ServerCertificateValidationCallback += (s, cert, chain, sslPolicyErrors) => true;
                }
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)192 | (SecurityProtocolType)768 | (SecurityProtocolType)3072;

                string url = UrlCombine(baseUrl, apiPath, param);

                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "Get";
                request.ContentType = "application/json;charset=utf-8";
                request.Proxy = null;
                request.Timeout = this.timeOut;


                SetWebRequestHeader(request, bearerToken);

                WebResponse response = await request.GetResponseAsync().ConfigureAwait(false);

                byte[] responseBytes = new byte[response.ContentLength];

                await response.GetResponseStream().ReadAsync(responseBytes, 0, (int)response.ContentLength).ConfigureAwait(false);

                string result = Encoding.UTF8.GetString(responseBytes);


                return result;
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message);
            }

        }

        public async Task<string> PostAsync(string baseUrl, string apiPath, Dictionary<string, string> param, CancellationToken cancellationToken, string bearerToken = null)
        {
            try
            {
                if (!rejectUnauthorized)
                {
                    ServicePointManager.ServerCertificateValidationCallback += (s, cert, chain, sslPolicyErrors) => true;
                }
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)192 | (SecurityProtocolType)768 | (SecurityProtocolType)3072;

                string url = UrlCombine(baseUrl, apiPath, null);
                string pa = m_JsonService.SerializeObject(param);

                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/json;charset=utf-8";
                request.Timeout = this.timeOut;


                SetWebRequestHeader(request, bearerToken);

                byte[] content = Encoding.UTF8.GetBytes(pa);
                request.ContentLength = content.Length;

                using (Stream reqStream = request.GetRequestStream())
                {
                    reqStream.Write(content, 0, content.Length);
                }

                WebResponse response = await request.GetResponseAsync().ConfigureAwait(false);

                byte[] responseBytes = new byte[response.ContentLength];

                await response.GetResponseStream().ReadAsync(responseBytes, 0, (int)response.ContentLength).ConfigureAwait(false);

                string result = Encoding.UTF8.GetString(responseBytes);


                return result;
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }

        public async Task<string> PostAsync(string baseUrl, string apiPath, string jsonParam, CancellationToken cancellationToken, string bearerToken = null)
        {
            try
            {
                if (!rejectUnauthorized)
                {
                    ServicePointManager.ServerCertificateValidationCallback += (s, cert, chain, sslPolicyErrors) => true;
                }
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)192 | (SecurityProtocolType)768 | (SecurityProtocolType)3072;

                string url = UrlCombine(baseUrl, apiPath, null);

                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/json;charset=utf-8";
                request.Proxy = null;
                request.Timeout = this.timeOut;

                SetWebRequestHeader(request, bearerToken);

                byte[] content = Encoding.UTF8.GetBytes(jsonParam);
                request.ContentLength = content.Length;

                using (Stream reqStream = request.GetRequestStream())
                {
                    reqStream.Write(content, 0, content.Length);
                }


                WebResponse response = await request.GetResponseAsync().ConfigureAwait(false);

                byte[] responseBytes = new byte[response.ContentLength];

                await response.GetResponseStream().ReadAsync(responseBytes, 0, (int)response.ContentLength).ConfigureAwait(false);

                string result = Encoding.UTF8.GetString(responseBytes);

                return result;
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }

        public async Task<string> PostFormAsync(string baseUrl, string apiPath, Dictionary<string, string> param, CancellationToken cancellationToken, string bearerToken = null)
        {
            try
            {
                if (!rejectUnauthorized)
                {
                    ServicePointManager.ServerCertificateValidationCallback += (s, cert, chain, sslPolicyErrors) => true;
                }
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)192 | (SecurityProtocolType)768 | (SecurityProtocolType)3072;

                string url = UrlCombine(baseUrl, apiPath, null);

                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.Proxy = null;
                request.Timeout = this.timeOut;

                SetWebRequestHeader(request, bearerToken);

                StringBuilder stringBuilder = new StringBuilder();
                foreach (var item in param)
                {
                    stringBuilder.AppendFormat("&{0}={1}", item.Key, item.Value);
                }

                stringBuilder = new StringBuilder(stringBuilder.ToString().Trim('&'));

                byte[] content = Encoding.UTF8.GetBytes(stringBuilder.ToString());
                request.ContentLength = content.Length;

                using (Stream reqStream = request.GetRequestStream())
                {
                    reqStream.Write(content, 0, content.Length);
                }


                WebResponse response = await request.GetResponseAsync().ConfigureAwait(false);

                byte[] responseBytes = new byte[response.ContentLength];

                await response.GetResponseStream().ReadAsync(responseBytes, 0, (int)response.ContentLength).ConfigureAwait(false);

                string result = Encoding.UTF8.GetString(responseBytes);

                return result;
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }

        public void SetBearerToken(string token)
        {
            m_BearerToken = token;
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

        public void ClearHeader()
        {
            m_HeadderDic.Clear();
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

            if (param is null || param.Count == 0)
            {
                return result;
            }

            string connector = "?";

            if (param != null)
            {
                foreach (var x in param)
                {
                    if (string.IsNullOrWhiteSpace(x.Value))
                    {
                        continue;
                    }

                    result += $"{connector}{x.Key}={x.Value}";
                    connector = "&";
                }
            }
            return result;
        }

        private HttpWebRequest SetWebRequestHeader(HttpWebRequest request, string bearerToken = null)
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
                if (item.Key == "date")
                {
                    continue;
                }

                request.Headers.Add(item.Key, item.Value);
            }

            return request;
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

