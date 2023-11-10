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
    /// CountCustomFieldsDto 的模型
    /// </summary>
    public partial class CountCustomFieldsDto
    {
        /// <summary>
        ///  记录总数
        /// </summary>
        [JsonProperty("all")]
        public long  All {get;set;}
        /// <summary>
        ///  计数
        /// </summary>
        [JsonProperty("userVisible")]
        public long  UserVisible {get;set;}
        /// <summary>
        ///  计数
        /// </summary>
        [JsonProperty("adminVisible")]
        public long  AdminVisible {get;set;}
    }
}