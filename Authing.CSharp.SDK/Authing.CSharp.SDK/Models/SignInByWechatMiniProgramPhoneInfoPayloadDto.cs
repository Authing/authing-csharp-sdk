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
    /// SignInByWechatMiniProgramPhoneInfoPayloadDto 的模型
    /// </summary>
    public partial class SignInByWechatMiniProgramPhoneInfoPayloadDto
    {
        /// <summary>
        ///  小程序获取用户手机号返回的 `code`
        /// </summary>
        [JsonProperty("code")]
        public string  Code  {get;set;}
    }
}