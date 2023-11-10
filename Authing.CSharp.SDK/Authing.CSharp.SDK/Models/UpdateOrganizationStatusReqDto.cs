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
    /// UpdateOrganizationStatusReqDto 的模型
    /// </summary>
    public partial class UpdateOrganizationStatusReqDto
    {
        /// <summary>
        ///  组织 id
        /// </summary>
        [JsonProperty("rootNodeId")]
        public string  RootNodeId {get;set;}
        /// <summary>
        ///  状态
        /// </summary>
        [JsonProperty("status")]
        public string  Status {get;set;}
    }
}