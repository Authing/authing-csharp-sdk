﻿using Authing.CSharp.SDK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Services
{
    public partial class AuthenticationClient
    {
        /// <summary>
        /// 此端点为基于直接 API 调用形式的登录端点，适用于你需要自建登录页面的场景。此端点暂时不支持 MFA、信息补全、首次密码重置等流程，如有需要，请使用 OIDC 标准协议认证端点。
        /// 用户认证完成之后，此接口会返回用户的 id_token 和 access_token。 id_token 是用户的身份凭证， access_token 是用户访问 后端资源的凭证，请求后端服务器的时候，你应该在 authorization 请求头中携带 access_token。
        /// </summary>
        /// <param name="loginByCredentialsDto"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public async Task<LoginTokenRespDto> Signin(LoginByCredentialsDto loginByCredentialsDto)
        {
            if (loginByCredentialsDto.Connection == Connection.PASSWORD &&
                string.IsNullOrWhiteSpace(loginByCredentialsDto.PasswordPayLoad.Password))
            {
                throw new ArgumentException("PasswodPayLoad.Password 不能为空");
            }
            else if (loginByCredentialsDto.Connection == Connection.PASSCODE &&
                string.IsNullOrWhiteSpace(loginByCredentialsDto.PassCodePayLoad.PassCode))
            {
                throw new ArgumentException("PassCodePayLoad.PassCode 不能为空");
            }
            else if (loginByCredentialsDto.Connection == Connection.AD &&
                 string.IsNullOrWhiteSpace(loginByCredentialsDto.ADPayLoad.PassCode))
            {
                throw new ArgumentException("ADPayLoad.PassCode 不能为空");
            }
            else if (loginByCredentialsDto.Connection == Connection.LDAP &&
                 string.IsNullOrWhiteSpace(loginByCredentialsDto.LDAPPayLoad.Password))
            {
                throw new ArgumentException("LDAPPayLoad.Password 不能为空");
            }

            string json = await PostAsync("api/v3/signin", loginByCredentialsDto);

            LoginTokenRespDto result = m_JsonService.DeserializeObject<LoginTokenRespDto>(json);

            return result;
        }

        /// <summary>
        /// 使用移动端社会化登录
        /// 如果你还没有配置对应的社会化登录，请先在 Authing 控制台进行配置。
        /// </summary>
        /// <param name="mobileSignInDto"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public async Task<LoginTokenRespDto> SigninByMobile(MobileSignInDto mobileSignInDto)
        {
            if (mobileSignInDto.Connection == MobileConnection.Wechat &&
                string.IsNullOrWhiteSpace(mobileSignInDto.WechatPayload.Code))
            {
                throw new ArgumentException("WechatPayload.Code 不能为空");
            }
            if (mobileSignInDto.Connection == MobileConnection.Alipay &&
                string.IsNullOrWhiteSpace(mobileSignInDto.AlipayPayload.Code))
            {
                throw new ArgumentException("AlipayPayload.Code 不能为空");
            }
            if (mobileSignInDto.Connection == MobileConnection.Wechatwork &&
                string.IsNullOrWhiteSpace(mobileSignInDto.WechatworkPayload.Code))
            {
                throw new ArgumentException("WechatworkPayload.Code 不能为空");
            }
            if (mobileSignInDto.Connection == MobileConnection.Wechatwork_agency &&
                string.IsNullOrWhiteSpace(mobileSignInDto.WechatworkAgencyPayload.Code))
            {
                throw new ArgumentException("WechatworkAgencyPayload.Code 不能为空");
            }
            if (mobileSignInDto.Connection == MobileConnection.Lark_internal &&
                string.IsNullOrWhiteSpace(mobileSignInDto.LarkInternalPayload.Code))
            {
                throw new ArgumentException("LarkInternalPayload.Code 不能为空");
            }
            if (mobileSignInDto.Connection == MobileConnection.Lark_public &&
                string.IsNullOrWhiteSpace(mobileSignInDto.LarkPublicPayload.Code))
            {
                throw new ArgumentException("LarkPublicPayload.Code 不能为空");
            }
            if (mobileSignInDto.Connection == MobileConnection.Yidun )
            {
                if (string.IsNullOrWhiteSpace(mobileSignInDto.YidunPayload.Token))
                {
                    throw new ArgumentException("YidunPayload.Token 不能为空");
                }
                if (string.IsNullOrWhiteSpace(mobileSignInDto.YidunPayload.AccessToken))
                { 
                    throw new ArgumentException("YidunPayload.AccessToken 不能为空");
                }
            }
            if (mobileSignInDto.Connection == MobileConnection.Wechat_mini_program_code)
            {
                if (string.IsNullOrWhiteSpace(mobileSignInDto.WechatMiniProgramCodePayload.EncryptedData))
                {
                    throw new ArgumentException("WechatMiniProgramCodePayload.EncryptedData 不能为空");
                }
                if (string.IsNullOrWhiteSpace(mobileSignInDto.WechatMiniProgramCodePayload.Iv))
                {
                    throw new ArgumentException("WechatMiniProgramCodePayload.Iv 不能为空");
                }
                if (string.IsNullOrWhiteSpace(mobileSignInDto.WechatMiniProgramCodePayload.Code))
                {
                    throw new ArgumentException("WechatMiniProgramCodePayload.Code 不能为空");
                }
            }
            if (mobileSignInDto.Connection == MobileConnection.Wechat_mini_program_phone)
            {
                if (string.IsNullOrWhiteSpace(mobileSignInDto.WechatMiniProgramPhonePayload.EncryptedData))
                {
                    throw new ArgumentException("WechatMiniProgramPhonePayload.EncryptedData 不能为空");
                }
                if (string.IsNullOrWhiteSpace(mobileSignInDto.WechatMiniProgramPhonePayload.Iv))
                {
                    throw new ArgumentException("WechatMiniProgramPhonePayload.Iv 不能为空");
                }
                if (string.IsNullOrWhiteSpace(mobileSignInDto.WechatMiniProgramPhonePayload.Code))
                {
                    throw new ArgumentException("WechatMiniProgramPhonePayload.Code 不能为空");
                }
            }

            string json = await PostAsync("/api/v3/signin-by-mobile", mobileSignInDto, AccessToken);

            LoginTokenRespDto result = m_JsonService.DeserializeObject<LoginTokenRespDto>(json);

            return result;
        }

        /// <summary>
        /// 生成用于登录的二维码，目前支持生成微信公众号扫码登录、小程序扫码登录、自建移动 APP 扫码登录的二维码。
        /// </summary>
        /// <param name="generateQrcodeDto"></param>
        /// <returns></returns>
        public async Task<GeneQRCodeRespDto> GeneQrcode(GenerateQrcodeDto generateQrcodeDto)
        {
            string json = await PostAsync("api/v3/gene-qrcode", generateQrcodeDto, AccessToken);

            GeneQRCodeRespDto result = m_JsonService.DeserializeObject<GeneQRCodeRespDto>(json);

            return result;
        }
    }
}
