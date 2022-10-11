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
/// ListOrganizationsDto 的模型
/// </summary>
public partial class ListOrganizationsDto
{
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
    ///  拉取所有
    /// </summary>
[JsonProperty("fetchAll")]
public    object   FetchAll    {get;set;}
    /// <summary>
    ///  是否获取自定义数据
    /// </summary>
[JsonProperty("withCustomData")]
public    object   WithCustomData    {get;set;}
}
}