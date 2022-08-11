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
    /// DeleteExtIdpDto 的模型
    /// </summary>
    public partial class DeleteExtIdpDto
    {
        /// <summary>
        ///  身份源 ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}