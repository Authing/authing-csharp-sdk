using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models.Management;

namespace Authing.CSharp.SDK.Models.Management
{
    /// <summary>
    /// CreateGroupBatchReqDto 的模型
    /// </summary>
    public partial class CreateGroupBatchReqDto
    {
        /// <summary>
        ///  批量分组
        /// </summary>
        [JsonProperty("list")]
        public List<CreateGroupReqDto> List { get; set; }
    }
}