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
    /// GetSubjectAuthDetailDto 的模型
    /// </summary>
    public partial class GetSubjectAuthDetailDto
    {
        /// <summary>
        ///  主体 id
        /// </summary>
        [JsonProperty("targetId")]
        public string  TargetId {get;set;} 
        /// <summary>
        ///  主体类型
        /// </summary>
        [JsonProperty("targetType")]
        public string  TargetType {get;set;} 
        /// <summary>
        ///  应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public string  AppId {get;set;} 
    }
}