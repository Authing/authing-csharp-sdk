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
/// GetAuthorizedResourcesDto 的模型
/// </summary>
public partial class GetAuthorizedResourcesDto
{
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
    ///  所属权限分组的 code
    /// </summary>
    [JsonProperty("namespace")]
    public string  Namespace {get;set;} 
    /// <summary>
    ///  限定资源类型，如数据、API、按钮、菜单
    /// </summary>
    [JsonProperty("resourceType")]
    public string  ResourceType {get;set;} 
    /// <summary>
    ///  限定查询的资源列表，如果指定，只会返回所指定的资源列表。
    /// </summary>
    [JsonProperty("resourceList")]
    public string  ResourceList {get;set;} 
    /// <summary>
    ///  是否获取被拒绝的资源
    /// </summary>
    [JsonProperty("withDenied")]
    public bool  WithDenied {get;set;} 
}
}