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
/// GetCustomDataDto 的模型
/// </summary>
public partial class GetCustomDataDto
{
    /// <summary>
    ///  主体类型，目前支持用户、角色、分组、部门
    /// </summary>
[JsonProperty("targetType")]
public    object   TargetType    {get;set;}
    /// <summary>
    ///  目标对象唯一标志符
    /// </summary>
[JsonProperty("targetIdentifier")]
public    object   TargetIdentifier    {get;set;}
    /// <summary>
    ///  所属权限分组的 code，当 targetType 为角色的时候需要填写，否则可以忽略
    /// </summary>
[JsonProperty("namespace")]
public    object   Namespace    {get;set;}
}
}