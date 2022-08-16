using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Authing.CSharp.SDK.Models.Authentication
{
    /// <summary>
    /// 解绑 MFA 认证要素传递参数类
    /// </summary>
    public class RestFactorDto
    {
        /// <summary>
        /// MFA 认证要素 ID
        /// </summary>
        [JsonProperty("factorId")]
        public string FactorId { get; set; }
    }
}
