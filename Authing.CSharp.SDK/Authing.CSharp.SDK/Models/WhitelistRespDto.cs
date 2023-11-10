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
    /// WhitelistRespDto 的模型
    /// </summary>
    public partial class WhitelistRespDto
    {
        /// <summary>
        ///  数据
        /// </summary>
        [JsonProperty("value")]
        public string  Value {get;set;}
        /// <summary>
        ///  创建时间
        /// </summary>
        [JsonProperty("createdAt")]
        public string  CreatedAt {get;set;}
    }
}