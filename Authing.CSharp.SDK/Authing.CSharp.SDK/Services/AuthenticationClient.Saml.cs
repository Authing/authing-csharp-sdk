using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authing.CSharp.SDK.Models;

namespace Authing.CSharp.SDK.Services
{
    /// <summary>
    /// TODO:补全该类所有方法
    /// </summary>
    public partial class AuthenticationClient
    {
        /// <summary>
        /// TODO:补全注释
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="samlrequest"></param>
        /// <param name="relayState"></param>
        /// <param name="signature"></param>
        /// <returns></returns>
        public async Task<CommonResponseDto> GetSaml(string appId, string samlrequest, string relayState, string signature)
        {
            string json = await GetAsync($"/api/v3/saml-idp/{appId}",
                m_JsonService.SerializeObject(new { SAMLRequest = samlrequest, RelayState = relayState, Signature = signature }), AccessToken).ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }

        /// <summary>
        /// TODO:补全注释
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        public async Task<CommonResponseDto> PostSaml(string appId)
        {
            string json = await PostFormAsync($"/api/v3/saml-idp/{appId}", AccessToken).ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }

        /// <summary>
        /// TODO:补全注释
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="relayState"></param>
        /// <returns></returns>
        public async Task<CommonResponseDto> GetSamlInit(string appId, string relayState)
        {
            string json = await GetAsync($"/api/v3/saml-idp/{appId}/init",
                m_JsonService.SerializeObject(new { RelayState = relayState }), AccessToken).ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }

        /// <summary>
        /// TODO:补全注释
        /// </summary>
        /// <param name="interactionkey"></param>
        /// <returns></returns>
        public async Task<CommonResponseDto> PostSamlInteractionkeyLogin(string interactionkey)
        {
            string json = await PostFormAsync($"/api/v3/saml-idp/{interactionkey}/login", AccessToken).ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }

        /// <summary>
        /// TODO:补全注释
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        public async Task<CommonResponseDto> GetSamlCert(string appId)
        {
            string json = await GetAsync($"/api/v3/saml-idp/{appId}/cert", "").ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }

        /// <summary>
        /// TODO:补全注释
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        public async Task<CommonResponseDto> GetSamlFingerprint(string appId)
        {
            string json = await GetAsync($"/api/v3/saml-idp/{appId}/cert/fingerprint", "").ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }

        /// <summary>
        /// TODO:补全注释
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        public async Task<CommonResponseDto> GetSamlMetadata(string appId)
        {
            string json = await GetAsync($"/api/v3/saml-idp/{appId}/metadata", "").ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }

        /// <summary>
        /// TODO:补全注释
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        public async Task<CommonResponseDto> GetSamlMetadataPreview(string appId)
        {
            string json = await GetAsync($"/api/v3/saml-idp/{appId}/metadata-preview", "").ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }
    }
}
