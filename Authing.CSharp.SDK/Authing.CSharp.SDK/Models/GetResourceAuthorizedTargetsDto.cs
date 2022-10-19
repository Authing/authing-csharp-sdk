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
/// GetResourceAuthorizedTargetsDto 的模型
/// </summary>
public partial class GetResourceAuthorizedTargetsDto
{
    /// <summary>
    ///  资源
    /// </summary>
    [JsonProperty("resource")]
    public string  Resource {get;set;}
    /// <summary>
    ///  权限分组
    /// </summary>
    [JsonProperty("namespace")]
    public string  Namespace {get;set;}
    /// <summary>
    ///  目标对象类型：
/// - `USER`: 用户
/// - `ROLE`: 角色
/// - `GROUP`: 分组
/// - `DEPARTMENT`: 部门
/// 
    /// </summary>
    [JsonProperty("targetType")]
    public targetType  TargetType {get;set;}
    /// <summary>
    ///  当前页数，从 1 开始
    /// </summary>
    [JsonProperty("page")]
    public long  Page {get;set;}
    /// <summary>
    ///  每页数目，最大不能超过 50，默认为 10
    /// </summary>
    [JsonProperty("limit")]
    public long  Limit {get;set;}
}
public partial class GetResourceAuthorizedTargetsDto
 {
    /// <summary>
    ///  目标对象类型：
/// - `USER`: 用户
/// - `ROLE`: 角色
/// - `GROUP`: 分组
/// - `DEPARTMENT`: 部门
/// 
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