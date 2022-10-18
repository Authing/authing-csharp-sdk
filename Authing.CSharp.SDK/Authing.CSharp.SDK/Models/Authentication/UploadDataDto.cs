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
    /// UploadDataDto 的模型
    /// </summary>
    public partial class UploadDataDto
    {
        /// <summary>
        ///  key
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }
        /// <summary>
        ///  url
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}