using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Authing.CSharp.SDK.Models.Authentication
{
    /// <summary>
    /// 解绑外部身份源参数类
    /// </summary>
    public class ULinkExtIdpParams
    {
        /// <summary>
        /// 用户绑定的外部身份源 ID
        /// </summary>
        [JsonProperty("extIdpId")]
        public string ExtIdpId { get; set; }
    }
}
