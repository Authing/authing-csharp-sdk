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
    /// GetWechatAccessTokenDto 的模型
    /// </summary>
    public partial class GetWechatAccessTokenDto
    {
        /// <summary>
        ///  微信小程序或微信公众号的 AppSecret
        /// </summary>
        [JsonProperty("appSecret")]
        public string AppSecret { get; set; }
        /// <summary>
        ///  微信小程序或微信公众号的 AppId
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }
    }
}