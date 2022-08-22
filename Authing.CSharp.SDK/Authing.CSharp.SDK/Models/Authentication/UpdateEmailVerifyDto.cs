using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class UpdateEmailVerifyDto
    {
        /// <summary>
        /// 验证方式
        /// </summary>
        public VerifyMethod VerifyMethod { get; set; }

        /// <summary>
        /// 使用邮箱验证码方式验证的数据
        /// </summary>
        public EmailPasscodePayload EmailPasscodePayload { get; set; }

    }

    public class EmailPasscodePayload
    { 
        public string NewEmail { get; set; }
        public string NewEmailPassCode { get; set; }
        public string OldEmail { get; set; }
        public string OldEmailPassCode { get; set; }
    }

    public enum VerifyMethod
    {
        [EnumMember(Value = "EMAIL_PASSCODE")]
        EMAIL_PASSCODE
    }
}
