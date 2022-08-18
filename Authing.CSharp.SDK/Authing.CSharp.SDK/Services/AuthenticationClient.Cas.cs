using System.Threading.Tasks;
using Authing.CSharp.SDK.Models;

namespace Authing.CSharp.SDK.Services
{
    public partial class AuthenticationClient
    {
        /// <summary>
        /// TODO:补全注释
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="service"></param>
        /// <param name="renew"></param>
        /// <param name="gateway"></param>
        /// <param name="method"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="it"></param>
        /// <param name="rememberMe"></param>
        /// <param name="warn"></param>
        /// <returns></returns>
        public async Task<CommonResponseDto> GetCasLogin(string appId, string service,
            string renew, string gateway, string method, string username, string password,
            string it, string rememberMe, string warn)
        {
            object param = new
            {
                service = service,
                renew = renew,
                gateway = gateway,
                method = method,
                username = username,
                password = password,
                It = it,
                rememberMe = rememberMe,
                warn = warn
            };
            string json = await GetAsync($"/cas-idp/{appId}/login", m_JsonService.SerializeObject(param)).ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }

        /// <summary>
        /// TODO:补全注释
        /// </summary>
        /// <returns></returns>
        public async Task<CommonResponseDto> PostCasLogin()
        {
            string json = await PostFormAsync($"/interaction/cas-idp/login", AccessToken).ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }

        /// <summary>
        /// TODO:补全注释
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="service"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<CommonResponseDto> GetCasLogout(string appId, string service, string url)
        {
            object param = new
            {
                service = service,
                url = url
            };
            string json = await GetAsync($"/cas-idp/{appId}/logout", m_JsonService.SerializeObject(param)).ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }

        /// <summary>
        /// TODO:补全注释 
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="service"></param>
        /// <param name="ticket"></param>
        /// <param name="renew"></param>
        /// <returns></returns>
        public async Task<CommonResponseDto> GetCasValidate(string appId, string service, string ticket, string renew)
        {
            object param = new
            {
                service = service,
                renew = renew,
                ticket = ticket,
            };
            string json = await GetAsync($"/cas-idp/{appId}/validate", m_JsonService.SerializeObject(param)).ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }

        /// <summary>
        /// TODO:补全注释 
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="service"></param>
        /// <param name="ticket"></param>
        /// <param name="pgtUrl"></param>
        /// <param name="renew"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public async Task<CommonResponseDto> GetCasValidate(string appId, string service, string ticket, string pgtUrl,string renew,string format)
        {
            object param = new
            {
                service = service,
                ticket = ticket,
                pgtUrl = pgtUrl,
                format = format,
                renew = renew,
            };
            string json = await GetAsync($"/cas-idp/{appId}/serviceValidate", m_JsonService.SerializeObject(param)).ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }


    }
}
