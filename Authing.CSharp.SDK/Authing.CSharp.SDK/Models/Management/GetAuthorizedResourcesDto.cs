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
/// GetAuthorizedResourcesDto 的模型
/// </summary>
public partial class GetAuthorizedResourcesDto
{
    /// <summary>
    ///  目标对象类型
    /// </summary>
    [JsonProperty("targetType")]
    public string  TargetType {get;set;} 
    /// <summary>
    ///  目标对象唯一标志符
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