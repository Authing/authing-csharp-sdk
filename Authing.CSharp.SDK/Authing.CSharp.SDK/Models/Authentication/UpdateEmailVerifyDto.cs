using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class UpdatePhoneVerifyDto
    {
        /// <summary>
        /// 验证方式
        /// </summary>
        public string VerifyMethod { get; set; }
        /// <summary>
        /// 原始密码
        /// </summary>
        public string VerifyData { get; set; }
    }
}
