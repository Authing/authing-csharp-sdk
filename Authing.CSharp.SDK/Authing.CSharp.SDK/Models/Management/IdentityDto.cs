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
    /// IdentityDto 的模型
    /// </summary>
    public partial class IdentityDto
    {
        /// <summary>
        ///  Identity ID
        /// </summary>
        [JsonProperty("identityId")]
        public string IdentityId { get; set; }
        /// <summary>
        ///  外部身份源的 ID
        /// </summary>
        [JsonProperty("extIdpId")]
        public string ExtIdpId { get; set; }
        /// <summary>
        ///  外部身份源类型，如 lark, wechat
        /// </summary>
        [JsonProperty("provider")]
        public string Provider { get; set; }
        /// <summary>
        ///  Identity 类型，如 unionid, openid, primary
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        ///  在外部身份源的 id
        /// </summary>
        [JsonProperty("userIdInIdp")]
        public string UserIdInIdp { get; set; }
        /// <summary>
        ///  身份来自的身份源连接 ID 列表
        /// </summary>
        [JsonProperty("originConnIds")]
        public List<string> OriginConnIds { get; set; }
    }
}