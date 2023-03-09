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
    /// LoginIpWhitelistCheckConfigDto 的模型
    /// </summary>
    public partial class LoginIpWhitelistCheckConfigDto
    {
        /// <summary>
        ///  是否开启登录 ip 白名单验证
        /// </summary>
        [JsonProperty("enabled")]
        public bool  Enabled  {get;set;}
        /// <summary>
        ///  人机验证 ip 白名单
        /// </summary>
        [JsonProperty("ipWhitelist")]
        public string  IpWhitelist  {get;set;}
    }
}