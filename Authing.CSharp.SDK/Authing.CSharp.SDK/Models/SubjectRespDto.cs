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
    /// SubjectRespDto 的模型
    /// </summary>
    public partial class SubjectRespDto
    {
        /// <summary>
        ///  主体 ID ，包含用户 ID、用户组 ID、角色 ID、组织机构 ID
        /// </summary>
        [JsonProperty("id")]
        public string  Id  {get;set;}
        /// <summary>
        ///  主体类型,包括 USER、GROUP、ROLE、ORG 四种类型
        /// </summary>
        [JsonProperty("type")]
        public type  Type  {get;set;}
        /// <summary>
        ///  主体名称，包含用户名称、用户组名称、角色名称、组织机构名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name  {get;set;}
    }
    public partial class SubjectRespDto
    {
        /// <summary>
        ///  主体类型,包括 USER、GROUP、ROLE、ORG 四种类型
        /// </summary>
        public enum type
        {
            [EnumMember(Value="USER")]
            USER,
            [EnumMember(Value="ORG")]
            ORG,
            [EnumMember(Value="GROUP")]
            GROUP,
            [EnumMember(Value="ROLE")]
            ROLE,
        }
    }
}