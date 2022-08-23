using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class DeleteAccountVerifyDto
    {
        public DeleteAccountVerifyDto()
        {
            EmailPassCodePayload = new DeleteAccountEmailPassCodePayload();
            PhonePassCodePayload = new DeleteAccountPhonePassCodePayload();
            PasswordPayload = new DeleteAccountPasswordPayload();
        }

        /// <summary>
        /// 验证方式
        /// </summary>
        public VerifyMethod VerifyMethod { get; set; }

        /// <summary>
        /// 使用邮箱验证码验证的数据
        /// </summary>
        public DeleteAccountEmailPassCodePayload EmailPassCodePayload { get; set; }

        /// <summary>
        /// 使用手机号验证码验证的数据
        /// </summary>
        public DeleteAccountPhonePassCodePayload PhonePassCodePayload { get; set; }
        /// <summary>
        /// 使用密码验证的数据
        /// </summary>
        public DeleteAccountPasswordPayload PasswordPayload { get; set; }
    }

    public class DeleteAccountPhonePassCodePayload
    {
        /// <summary>
        /// 此账号绑定的手机号，不带区号。如果是国外手机号，请在 phoneCountryCode 参数中指定区号。
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 短信验证码，一个短信验证码只能使用一次，有效时间为一分钟。你需要通过发送短信接口获取。
        /// </summary>
        public string PassCode { get; set; }
        /// <summary>
        /// 手机区号
        /// </summary>
        public string PhoneCountryCode { get; set; }
    }

    public class DeleteAccountEmailPassCodePayload
    {
        /// <summary>
        /// 此账号绑定的邮箱，不区分大小写
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 邮箱验证码，一个短信验证码只能使用一次，默认有效时间为无分钟。你需要通过发送邮件接口获取。
        /// </summary>
        public string PassCode { get; set; }
    }

    public class DeleteAccountPasswordPayload
    {
        /// <summary>
        /// 用户密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 密码加密类型，支持 sm2 和 rsa。默认可以不加密。
        /// </summary>
        public PasswordEncryptType PasswordEncryptType { get; set; }
    }
}
