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
    /// GetAllGroupsDto 的模型
    /// </summary>
    public partial class GetAllGroupsDto
    {
        /// <summary>
        ///  是否获取成员列表
        /// </summary>
        [JsonProperty("fetchMembers")]
        public bool  FetchMembers {get;set;} 
        /// <summary>
        ///  是否获取自定义数据
        /// </summary>
        [JsonProperty("withCustomData")]
        public bool  WithCustomData {get;set;} 
    }
}