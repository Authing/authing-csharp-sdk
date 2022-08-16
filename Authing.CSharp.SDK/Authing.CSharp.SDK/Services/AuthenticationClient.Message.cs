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
        /// 发送短信
        /// </summary>
        /// <param name="param">发送短信参数类</param>
        /// <returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> SendSms(SendSMSDto param)
        {
            string json = await PostAsync("POST", "/api/v3/send-sms", param, AccessToken).ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="param">发送邮件参数类</param>
        /// <returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> SendEmail(SendEmailDto param)
        {
            string json = await PostAsync("POST", "/api/v3/send-email", param, AccessToken).ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }
    }
}
