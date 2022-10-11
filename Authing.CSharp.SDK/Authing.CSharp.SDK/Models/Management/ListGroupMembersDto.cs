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
/// ListGroupMembersDto 的模型
/// </summary>
public partial class ListGroupMembersDto
{
    /// <summary>
    ///  分组 code
    /// </summary>
[JsonProperty("code")]
public    object   Code    {get;set;}
    /// <summary>
    ///  当前页数，从 1 开始
    /// </summary>
[JsonProperty("page")]
public    object   Page    {get;set;}
    /// <summary>
    ///  每页数目，最大不能超过 50，默认为 10
    /// </summary>
[JsonProperty("limit")]
public    object   Limit    {get;set;}
    /// <summary>
    ///  是否获取自定义数据
    /// </summary>
[JsonProperty("withCustomData")]
public    object   WithCustomData    {get;set;}
    /// <summary>
    ///  是否获取 identities
    /// </summary>
[JsonProperty("withIdentities")]
public    object   WithIdentities    {get;set;}
    /// <summary>
    ///  是否获取部门 ID 列表
    /// </summary>
[JsonProperty("withDepartmentIds")]
public    object   WithDepartmentIds    {get;set;}
}
}