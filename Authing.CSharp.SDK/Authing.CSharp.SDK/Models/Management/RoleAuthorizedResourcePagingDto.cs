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
/// RoleAuthorizedResourcePagingDto 的模型
/// </summary>
public partial class RoleAuthorizedResourcePagingDto
{
    /// <summary>
    ///  记录总数
    /// </summary>
[JsonProperty("totalCount")]
public    long   TotalCount    {get;set;}
    /// <summary>
    ///  数据
    /// </summary>
[JsonProperty("list")]
public    List<RoleAuthorizedResourcesRespDto>   List    {get;set;}
}
}