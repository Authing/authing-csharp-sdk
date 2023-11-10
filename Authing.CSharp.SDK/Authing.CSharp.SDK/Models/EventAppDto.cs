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
    /// EventAppDto 的模型
    /// </summary>
    public partial class EventAppDto
    {
        /// <summary>
        ///  唯一标识
        /// </summary>
        [JsonProperty("identifier")]
        public string  Identifier {get;set;}
        /// <summary>
        ///  应用名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  应用 logo
        /// </summary>
        [JsonProperty("logo")]
        public string  Logo {get;set;}
    }
}