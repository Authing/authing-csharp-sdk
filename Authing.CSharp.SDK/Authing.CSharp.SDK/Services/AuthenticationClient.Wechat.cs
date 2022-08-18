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
        //TODO:方法返回值须修改
        /// <summary>
        /// 解密微信小程序数据
        /// </summary>
        /// <param name="param">解密微信小程序数据请求参数类</param>
        /// <returns></returns>
        public async Task<CommonResponseDto> DecryptWechatMiniprogramData(DecryptWechatMiniProgramDataDto param)
        {
            string json = await PostFormAsync("/api/v3/decrypt-wechat-miniprogram-data", param, AccessToken).ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }

    }
}
