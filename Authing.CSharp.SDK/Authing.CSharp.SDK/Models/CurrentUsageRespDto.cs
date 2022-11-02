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
    /// CurrentUsageRespDto 的模型
    /// </summary>
    public partial class CurrentUsageRespDto
    {
        /// <summary>
        ///  当前用量实体
        /// </summary>
        [JsonProperty("usages")]
        public List<CurrentUsageDto>  Usages {get;set;}
    }
}