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
    /// SetCustomDataReqDto 的模型
    /// </summary>
    public partial class SetCustomDataReqDto
    {
        /// <summary>
        ///  自定义数据列表
        /// </summary>
        [JsonProperty("list")]
        public    List<SetCustomDataDto>   List    {get;set;}
        /// <summary>
        ///  主体类型的唯一标志符。如果是用户则为用户 ID，角色为角色的 code，部门为部门的 ID
        /// </summary>
        [JsonProperty("targetIdentifier")]
        public    string   TargetIdentifier    {get;set;}
        /// <summary>
        ///  主体类型，目前支持用户、角色、分组和部门
        /// </summary>
        [JsonProperty("targetType")]
        public    SetCustomDataReqDto.targetType   TargetType    {get;set;}
        /// <summary>
        ///  所属权限分组的 code，当 target_type 为角色的时候需要填写，否则可以忽略。
        /// </summary>
        [JsonProperty("namespace")]
        public    string   Namespace    {get;set;}
    }
    public partial class SetCustomDataReqDto
    {
        /// <summary>
        ///  主体类型，目前支持用户、角色、分组和部门
        /// </summary>
        public enum targetType
        {
            [EnumMember(Value="USER")]
            USER,
            [EnumMember(Value="ROLE")]
            ROLE,
            [EnumMember(Value="GROUP")]
            GROUP,
            [EnumMember(Value="DEPARTMENT")]
            DEPARTMENT,
        }
    }
}