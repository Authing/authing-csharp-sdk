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
/// GetRoleAuthorizedResourcesDto 的模型
/// </summary>
public partial class GetRoleAuthorizedResourcesDto
{
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
    ///  资源类型，如 数据、API、按钮、菜单
    /// </summary>
    [JsonProperty("resourceType")]
    public string  ResourceType {get;set;} 
}
}