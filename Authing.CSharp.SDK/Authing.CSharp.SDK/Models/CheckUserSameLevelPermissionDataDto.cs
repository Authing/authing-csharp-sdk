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
    /// CheckUserSameLevelPermissionDataDto 的模型
    /// </summary>
    public partial class CheckUserSameLevelPermissionDataDto
    {
        /// <summary>
        ///  响应结果列表
        /// </summary>
        [JsonProperty("checkLevelResultList")]
        public List<CheckUserSameLevelPermissionRespDto>  CheckLevelResultList  {get;set;}
    }
}