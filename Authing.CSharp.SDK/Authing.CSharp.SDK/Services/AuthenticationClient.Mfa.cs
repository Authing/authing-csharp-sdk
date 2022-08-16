using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Models.Authentication;

namespace Authing.CSharp.SDK.Services
{
    public partial class AuthenticationClient
    {
        /// <summary>
        /// 发起绑定 MFA 认证要素请求
        /// </summary>
        /// <param name="param">发起绑定 MFA 认证要素请求参数类</param>
        /// <returns>SendEnrollFactorRequestRespDto</returns>
        public async Task<SendEnrollFactorRequestRespDto> SendEnroolFactorRequest(SendEnrollFactorRequestDto param)
        {
            string json = await PostAsync("POST", "/api/v3/send-enroll-factor-request", param, AccessToken).ConfigureAwait(false);
            SendEnrollFactorRequestRespDto res = jsonService.DeserializeObject<SendEnrollFactorRequestRespDto>(json);
            return res;
        }

        /// <summary>
        /// 绑定 MFA 认证要素
        /// </summary>
        /// <param name="param">绑定 MFA 认证要素请求参数类</param>
        /// <returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> EnrollFactor(EnrollFactorDto param)
        {
            string json = await PostAsync("POST", "/api/v3/enroll-factor", param, AccessToken).ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }

        /// <summary>
        /// 解绑 MFA 认证要素
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<CommonResponseDto> ResetFactor(RestFactorDto param)
        {
            string json = await PostAsync("POST", "/api/v3/enroll-factor", param, AccessToken).ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }

        /// <summary>
        /// 获取绑定的所有 MFA 认证要素
        /// </summary>
        /// <returns>ListEnrolledFactorsRespDto</returns>
        public async Task<ListEnrolledFactorsRespDto> ListEnrolledFactors()
        {
            string json = await GetWithBearerTokenAsync($"{domain}/api/v3/list-enrolled-factors", "", AccessToken).ConfigureAwait(false);
            ListEnrolledFactorsRespDto res = jsonService.DeserializeObject<ListEnrolledFactorsRespDto>(json);
            return res;
        }

        /// <summary>
        /// 获取绑定的某个 MFA 认证要素
        /// </summary>
        /// <param name="factorId"></param>
        /// <returns></returns>
        public async Task<GetFactorRespDto> GetFactor(string factorId)
        {
            string json = await GetWithBearerTokenAsync($"{domain}/api/v3/list-enrolled-factors?factorId={factorId}", "", AccessToken).ConfigureAwait(false);
            GetFactorRespDto res = jsonService.DeserializeObject<GetFactorRespDto>(json);
            return res;
        }

        /// <summary>
        /// 获取可绑定的 MFA 认证要素
        /// </summary>
        /// <returns></returns>
        public async Task<ListFactorsToEnrollRespDto> ListFactorsToEnroll()
        {
            string json = await GetWithBearerTokenAsync($"{domain}/api/v3/list-factors-to-enroll", "", AccessToken).ConfigureAwait(false);
            ListFactorsToEnrollRespDto res = jsonService.DeserializeObject<ListFactorsToEnrollRespDto>(json);
            return res;
        }
    }
}
