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
    /// CheckPermissionDataDto 的模型
    /// </summary>
    public partial class CheckPermissionDataDto
    {
        /// <summary>
        ///  检查结果列表
        /// </summary>
        [JsonProperty("checkResultList")]
        public List<CheckPermissionsRespDto>  CheckResultList {get;set;}
    }
}