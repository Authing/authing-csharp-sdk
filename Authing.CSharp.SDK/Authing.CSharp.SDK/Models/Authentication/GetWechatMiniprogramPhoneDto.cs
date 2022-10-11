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
    /// GetWechatMiniProgramPhoneDto 的模型
    /// </summary>
    public partial class GetWechatMiniProgramPhoneDto
    {
        /// <summary>
        ///  `open-type=getphonecode` 接口返回的 `code`
        /// </summary>
        [JsonProperty("code")]
        public    string   Code    {get;set;}
        /// <summary>
        ///  微信小程序的外部身份源连接标志符
        /// </summary>
        [JsonProperty("extIdpConnidentifier")]
        public    string   ExtIdpConnidentifier    {get;set;}
    }
}