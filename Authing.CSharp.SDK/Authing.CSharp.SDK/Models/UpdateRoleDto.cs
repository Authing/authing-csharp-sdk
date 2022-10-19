using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models;

   namespace Authing.CSharp.SDK.Models
{
/// <summary>
/// UpdateRoleDto 的模型
/// </summary>
public partial class UpdateRoleDto
{
    /// <summary>
    ///  角色新的权限分组内唯一识别码
    /// </summary>
    [JsonProperty("newCode")]
    public string  NewCode {get;set;}
    /// <summary>
    ///  权限分组内角色的唯一标识符
    /// </summary>
    [JsonProperty("code")]
    public string  Code {get;set;}
    /// <summary>
    ///  所属权限分组的 code
    /// </summary>
    [JsonProperty("namespace")]
    public string  Namespace {get;set;}
    /// <summary>
    ///  角色描述
    /// </summary>
    [JsonProperty("description")]
    public string  Description {get;set;}
}
}