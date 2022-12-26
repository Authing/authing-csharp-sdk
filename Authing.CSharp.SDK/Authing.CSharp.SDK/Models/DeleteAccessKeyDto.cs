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
    /// DeleteAccessKeyDto 的模型
    /// </summary>
    public partial class DeleteAccessKeyDto
    {
        /// <summary>
        ///  accessKeyId
        /// </summary>
        [JsonProperty("accessKeyId")]
        public string  AccessKeyId {get;set;}
    }
}