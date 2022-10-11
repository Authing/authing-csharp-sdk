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
/// DeleteApplicationPermissionRecordItem 的模型
/// </summary>
public partial class DeleteApplicationPermissionRecordItem
{
    /// <summary>
    ///  主体类型
    /// </summary>
[JsonProperty("targetType")]
public    targetType   TargetType    {get;set;}
    /// <summary>
    ///  权限分组 code，当主体类型为 "ROLE" 时必传
    /// </summary>
[JsonProperty("namespaceCode")]
public    string   NamespaceCode    {get;set;}
    /// <summary>
    ///  主体标识列表，当主体类型为 "USER" 时，值应为用户 ID；当主体类型为 "GROUP" 时，值应为分组 code；当主体类型为 "ROLE" 时，值应为角色 code；当主体类型为 "ORG" 时，值应为组织节点 ID。最多 50 条。
    /// </summary>
[JsonProperty("targetIdentifier")]
public    List<string>   TargetIdentifier    {get;set;}
}
public partial class DeleteApplicationPermissionRecordItem
 {
    /// <summary>
    ///  主体类型
    /// </summary>
    public enum targetType
     {
         [EnumMember(Value="USER")]
        USER,
         [EnumMember(Value="ROLE")]
        ROLE,
         [EnumMember(Value="GROUP")]
        GROUP,
         [EnumMember(Value="ORG")]
        ORG,
    }
}
}