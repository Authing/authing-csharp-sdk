using Authing.CSharp.SDK.Extensions;
using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Utils;
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

        public BaseManagementService(ManagementClientOptions options) : base(new JsonService())
        {
            m_UserPoolId =options.AccessKeyId;
            m_Secret = options.AccessKeySecret;

            m_BaseUrl = ConfigService.BASE_URL;

            if (!string.IsNullOrWhiteSpace(options.Host))
            {
                m_BaseUrl = options.Host;
            }
          
        }

        protected async Task<string> PostAsync(string apiPath, string param)
        {
            await CheckToken();

            string httpResponse = await m_HttpService.PostAsync(m_BaseUrl, apiPath, param, default).ConfigureAwait(false);
            return httpResponse;
        }


        protected async Task<string> Request(string method, string apiPath, Dictionary<string, object> pairs,bool withToken=true)
        {
            if (withToken)
            {
                await CheckToken().ConfigureAwait(false);
            }

            Dictionary<string, string> dic = pairs.ToDictionary((keyItem) => keyItem.Key, (valueItem) => valueItem.Value==null?"":valueItem.Value.ToString());

            string httpResponse = await m_HttpService.GetAsync(m_BaseUrl, apiPath, dic, default).ConfigureAwait(false);
            return httpResponse;
        }

        protected async Task<string> Request<T>(string method,string apiPath, T dto,bool withToken=true)
        {
            if (withToken)
            {
                await CheckToken().ConfigureAwait(false);
            }

            string json = m_JsonService.SerializeObject(dto);

            string httpResponse = await m_HttpService.PostAsync(m_BaseUrl, apiPath, json, default).ConfigureAwait(false);
            return httpResponse;
        }

        

        private async Task CheckToken()
        {
            if (m_TokenInfo == null || !this.IfTokenValid(m_TokenInfo.Data.Expires_in))
            {
                await GetManagementToken(default).ConfigureAwait(false);
            }

            m_HttpService.SetBearerToken(m_TokenInfo.Data.Access_token);
            m_HttpService.SetHeader("x-authing-userpool-id", m_UserPoolId);
            m_HttpService.SetHeader("x-authing-request-from", "SDK");
            m_HttpService.SetHeader("x-authing-sdk-version", "c-sharp:5.0.0");
        }



        private async Task GetManagementToken(CancellationToken cancellationToken)
        {
            GetManagementAccessTokenDto dto = new GetManagementAccessTokenDto()
            {
                AccessKeyId = m_UserPoolId,
                AccessKeySecret = m_Secret
            };

            string json = BuildHttpPostRequest(dto);

            string httpResponse = await m_HttpService.PostAsync(ConfigService.BASE_URL, "/api/v3/get-management-token", json, cancellationToken).ConfigureAwait(false);

            GetManagementTokenRespDto result = m_JsonService.DeserializeObject<GetManagementTokenRespDto>(httpResponse);

            m_TokenInfo = result;

        }
    }
}
