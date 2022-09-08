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

        //TODO:方法返回值需修改
        /// <summary>
        /// 获取小程序的手机号
        /// </summary>
        /// <param name="param">获取小程序的手机号参数类</param>
        /// <returns></returns>
        public async Task<CommonResponseDto> GetWechatMiniprogramPhone(GetWechatMiniprogramPhoneDto param)
        {
            string json = await PostFormAsync("/api/v3/get-wechat-miniprogram-phone", param, AccessToken).ConfigureAwait(false);
            CommonResponseDto res = jsonService.DeserializeObject<CommonResponseDto>(json);
            return res;
        }

        /// <summary>
        /// 获取 Authing 服务器缓存的微信小程序、公众号 Access Token
        /// </summary>
        /// <param name="param">获取 Authing 服务器缓存的微信小程序、公众号 Access Token 参数类</param>
        /// <returns></returns>
        public async Task<GetWechatAccessTokenResDto> GetWechatAccessToken(GetWechatAccessTokenDto param)
        {
            string json = await PostFormAsync("/api/v3/get-wechat-access-token", param, AccessToken).ConfigureAwait(false);
            GetWechatAccessTokenResDto res = jsonService.DeserializeObject<GetWechatAccessTokenResDto>(json);
            return res;
        }

    }
}
