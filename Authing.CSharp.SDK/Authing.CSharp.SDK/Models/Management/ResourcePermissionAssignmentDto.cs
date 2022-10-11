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
/// ResourcePermissionAssignmentDto 的模型
/// </summary>
public partial class ResourcePermissionAssignmentDto
{
    /// <summary>
    ///  主体类型
    /// </summary>
[JsonProperty("targetType")]
public    targetType   TargetType    {get;set;}
    /// <summary>
    ///  主体唯一标志符
    /// </summary>
[JsonProperty("targetIdentifier")]
public    string   TargetIdentifier    {get;set;}
    /// <summary>
    ///  操作列表
    /// </summary>
[JsonProperty("actions")]
public    List<string>   Actions    {get;set;}
}
public partial class ResourcePermissionAssignmentDto
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
         [EnumMember(Value="DEPARTMENT")]
        DEPARTMENT,
    }
}
}