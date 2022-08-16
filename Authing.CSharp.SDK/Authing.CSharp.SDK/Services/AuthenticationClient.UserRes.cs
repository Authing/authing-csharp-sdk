using System.Threading.Tasks;
using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Models.Authentication;

namespace Authing.CSharp.SDK.Services
{
    public partial class AuthenticationClient
    {
        /// <summary>
        /// 获取登录日志
        /// </summary>
        /// <param name="param">获取登录日志参数类</param>
        /// <returns></returns>
        public async Task<CommonResponseDto> GetLoginHistory(GetLoginHistoryDto param)
        {
            string json = await PostAsync("POST", "/api/v3/get-login-history", param, AccessToken).ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }
    }
}
