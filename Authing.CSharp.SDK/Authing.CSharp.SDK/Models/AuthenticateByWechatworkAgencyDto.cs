using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Authing.CSharp.SDK.Models
{
    /// <summary>
    /// AuthenticateByWechatworkAgencyDto 的模型
    /// </summary>
    public partial class AuthenticateByWechatworkAgencyDto
    {
        /// <summary>
        ///  企业微信（代开发模式）移动端社会化登录返回的一次性临时 code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}