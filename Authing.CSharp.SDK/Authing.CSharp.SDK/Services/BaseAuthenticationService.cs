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

        public BaseAuthenticationService(string domain) : base(new JsonService())
        {
            m_BaseUrl = ConfigService.BASE_URL;

            if (!string.IsNullOrWhiteSpace(domain))
            {
                m_BaseUrl = domain;
            }
        }

        protected async Task<string> GetAsync(string apiPath, string param)
        {

            var dic = m_JsonService.DeserializeObject<Dictionary<string, string>>(param);

            string httpResponse = await m_HttpService.GetAsync(m_BaseUrl, apiPath, dic, default).ConfigureAwait(false);
            return httpResponse;
        }

        protected async Task<string> GetWithBearerTokenAsync(string apiPath, string param, string accessToken)
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

        protected async Task<string> PostFormAsync<T>(string method, string apiPath, T dto, Dictionary<string, string> headers = null)
        {
            string json = m_JsonService.SerializeObject(dto);
            Dictionary<string, string> dic = m_JsonService.DeserializeObject<Dictionary<string, string>>(json);

            SetHeaders();

            string httpResponse = await m_HttpService.PostFormAsync(m_BaseUrl, apiPath, dic, default).ConfigureAwait(false);
            return httpResponse;
        }

        private void SetHeaders()
        {
            m_HttpService.SetHeader("x-authing-request-from", "SDK");
            m_HttpService.SetHeader("x-authing-sdk-version", "c-sharp:5.0.0");
        }
    }
}
