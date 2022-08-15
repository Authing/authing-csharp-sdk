using System.Threading.Tasks;
using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Models.Authentication;
using Newtonsoft.Json;

namespace Authing.CSharp.SDK.Services
{
    public partial class AuthenticationClient
    {
        /// <summary>
        /// 用户 Token
        /// </summary>
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 绑定外部身份源
        /// </summary>
        /// <param name="extIdpConnIdentifier">外部身份源连接唯一标志</param>
        /// <param name="appId">Authing 应用 ID</param>
        /// <param name="idToken">用户的 id_token</param>
        /// <returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> LinkExtIdp(string extIdpConnIdentifier, string appId, string idToken)
        {
            LinkExtIdpParams param = new LinkExtIdpParams()
            {
                ExtIdpConnIdentifier = extIdpConnIdentifier,
                AppId = appId,
                IdToken = idToken
            };
            string json = await GetWithBearerTokenAsync($"{domain}/api/v3/link-extidp?{CreateQueryParams(param)}", "", AccessToken).ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }

        /// <summary>
        /// 解绑外部身份源
        /// </summary>
        /// <param name="extIdpId">用户绑定的外部身份源 ID</param>
        /// <returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> ULinkExtIdp(string extIdpId)
        {
            ULinkExtIdpParams param = new ULinkExtIdpParams() { ExtIdpId = extIdpId };
            string json = await PostFormAsync("POST", "/api/v3/unlink-extidp", param).ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }

        /// <summary>
        /// 获取绑定的外部身份源
        /// </summary>
        /// <returns>GetIdentitiesRespDto</returns>
        public async Task<GetIdentitiesRespDto> GetIdentities()
        {
            string json = await GetWithBearerTokenAsync($"{domain}/api/v3/get-identities", "", AccessToken).ConfigureAwait(false);
            GetIdentitiesRespDto res = jsonService.DeserializeObject<GetIdentitiesRespDto>(json);
            return res;
        }

        public async Task<GetExtIdpsRespDto> GetExtIdps()
        {
            string json = await GetWithBearerTokenAsync($"{domain}/api/v3/get-extidps", "", AccessToken).ConfigureAwait(false);
            GetExtIdpsRespDto res = jsonService.DeserializeObject<GetExtIdpsRespDto>(json);
            return res;
        }
    }
}
