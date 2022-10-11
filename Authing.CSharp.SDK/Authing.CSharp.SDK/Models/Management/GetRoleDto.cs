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
/// GetRoleDto 的模型
/// </summary>
public partial class GetRoleDto
{
    /// <summary>
    ///  权限分组内角色的唯一标识符
    /// </summary>
[JsonProperty("code")]
public    object   Code    {get;set;}
    /// <summary>
    ///  所属权限分组的 code
    /// </summary>
[JsonProperty("namespace")]
public    object   Namespace    {get;set;}
}
}