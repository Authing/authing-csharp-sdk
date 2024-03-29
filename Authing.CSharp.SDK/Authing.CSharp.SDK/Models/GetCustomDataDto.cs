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
    /// GetCustomDataDto 的模型
    /// </summary>
    public partial class GetCustomDataDto
    {
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;} 
        /// <summary>
        ///  目标对象类型：
/// - `USER`: 用户
/// - `ROLE`: 角色
/// - `GROUP`: 分组
/// - `DEPARTMENT`: 部门
/// 
        /// </summary>
        [JsonProperty("targetType")]
        public string  TargetType {get;set;} 
        /// <summary>
        ///  目标对象的唯一标志符：
/// - 如果是用户，为用户的 ID，如 `6343b98b7cfxxx9366e9b7c`
/// - 如果是角色，为角色的 code，如 `admin`
/// - 如果是分组，为分组的 code，如 `developer`
/// - 如果是部门，为部门的 ID，如 `6343bafc019xxxx889206c4c`
/// 
        /// </summary>
        [JsonProperty("targetIdentifier")]
        public string  TargetIdentifier {get;set;} 
        /// <summary>
        ///  所属权限分组的 code，当 targetType 为角色的时候需要填写，否则可以忽略
        /// </summary>
        [JsonProperty("namespace")]
        public string  Namespace {get;set;} 
    }
}