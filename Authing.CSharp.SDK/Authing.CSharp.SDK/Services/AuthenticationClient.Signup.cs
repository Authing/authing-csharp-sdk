using Authing.CSharp.SDK.Models;
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
        /// 注册
        /// 此端点目前支持以下几种基于的注册方式： 
        /// 基于密码（PASSWORD）：用户名 + 密码，邮箱 + 密码。
        /// 基于一次性临时验证码（PASSCODE）：手机号 + 验证码，邮箱 + 验证码。
        /// 你需要先调用发送短信或者发送邮件接口获取验证码。社会化登录等使用外部身份源“注册”请直接使用登录接口，我们会在其第一次登录的时候为其创建一个新账号。
        /// </summary>
        /// <param name="signupDto"></param>
        /// <returns></returns>
        public async Task<UserSingleRespDto> Signup(SignupDto signupDto)
        {
            if (signupDto.Connection == SignupConnection.PASSWORD)
            {
                if (string.IsNullOrWhiteSpace(signupDto.PasswordPayload.Password))
                {
                    throw new ArgumentException("PasswordPayload.Password 不能为空");
                }

                if (string.IsNullOrWhiteSpace(signupDto.Profile.Email))
                {
                    signupDto.Profile.Email = signupDto.PasswordPayload.Email;
                    signupDto.PassCodePayload.Email = signupDto.PasswordPayload.Email;
                }
            }

            if (signupDto.Connection == SignupConnection.PASSCODE)
            {
                if (string.IsNullOrWhiteSpace(signupDto.PassCodePayload.PassCode))
                {
                    throw new ArgumentException("PassCodePayload.PassCode 不能为空");
                }

                if (string.IsNullOrWhiteSpace(signupDto.Profile.Email) && !string.IsNullOrWhiteSpace(signupDto.PassCodePayload.Email))
                {
                    signupDto.Profile.Email = signupDto.PassCodePayload.Email;
                    signupDto.PasswordPayload.Email = signupDto.PassCodePayload.Email;
                }

                if (string.IsNullOrWhiteSpace(signupDto.Profile.Phone) && !string.IsNullOrWhiteSpace(signupDto.PassCodePayload.Phone))
                {
                    signupDto.Profile.Phone = signupDto.PassCodePayload.Phone;
                }
            }


            string json = await PostAsync("/api/v3/signup", m_JsonService.SerializeObjectCamelCase(signupDto), "");

            UserSingleRespDto result = m_JsonService.DeserializeObject<UserSingleRespDto>(json);

            return result;
        }
    }
}
