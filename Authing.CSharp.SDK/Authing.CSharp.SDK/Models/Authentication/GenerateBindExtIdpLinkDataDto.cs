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
    /// GenerateBindExtIdpLinkDataDto 的模型
    /// </summary>
    public partial class GenerateBindExtIdpLinkDataDto
    {
        /// <summary>
        ///  用户绑定外部身份源的链接
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}