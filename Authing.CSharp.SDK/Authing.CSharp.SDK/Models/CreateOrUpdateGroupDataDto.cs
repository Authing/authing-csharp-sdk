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
    /// CreateOrUpdateGroupDataDto 的模型
    /// </summary>
    public partial class CreateOrUpdateGroupDataDto
    {
        /// <summary>
        ///  是否创建
        /// </summary>
        [JsonProperty("created")]
        public bool  Created {get;set;}
        /// <summary>
        ///  群组信息
        /// </summary>
        [JsonProperty("data")]
        public GroupDto  Data {get;set;}
    }
}