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
    /// GenerateLinkExtidpUrlDto 的模型
    /// </summary>
    public partial class GenerateLinkExtidpUrlDto
    {
        /// <summary>
        ///  外部身份源连接唯一标志
        /// </summary>
        [JsonProperty("extIdpConnIdentifier")]
        public object ExtIdpConnIdentifier { get; set; }
        /// <summary>
        ///  Authing 应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public object AppId { get; set; }
        /// <summary>
        ///  用户的 id_token
        /// </summary>
        [JsonProperty("idToken")]
        public object IdToken { get; set; }
    }
}