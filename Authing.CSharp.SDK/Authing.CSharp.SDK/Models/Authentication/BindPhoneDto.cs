using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class BindPhoneDto
    {
        /// <summary>
        /// 手机
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 验证码
        /// </summary>
        public string PassCode { get; set; }
        /// <summary>
        /// 电话国际区域码
        /// </summary>
        public string PhoneCountryCode { get; set; }
    }
}
