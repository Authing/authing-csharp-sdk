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
/// ListRoleDepartmentsDto 的模型
/// </summary>
public partial class ListRoleDepartmentsDto
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
    ///  当前页数，从 1 开始
    /// </summary>
    [JsonProperty("page")]
    public long  Page {get;set;} =1;
    /// <summary>
    ///  每页数目，最大不能超过 50，默认为 10
    /// </summary>
    [JsonProperty("limit")]
    public long  Limit {get;set;} =10;
}
}