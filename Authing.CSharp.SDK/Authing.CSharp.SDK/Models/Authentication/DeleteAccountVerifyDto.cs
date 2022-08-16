using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class DeleteAccountVerifyDto
    {
        /// <summary>
        /// 验证方式
        /// </summary>
        public string VerifyMethod { get; set; }
        /// <summary>
        /// 验证数据
        /// </summary>
        public string VerifyData { get; set; }
    }
}
