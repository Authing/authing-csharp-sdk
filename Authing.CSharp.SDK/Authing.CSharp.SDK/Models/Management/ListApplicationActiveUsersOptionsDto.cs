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
/// ListApplicationActiveUsersOptionsDto 的模型
/// </summary>
public partial class ListApplicationActiveUsersOptionsDto
{
    /// <summary>
    ///  分页配置
    /// </summary>
    [JsonProperty("pagination")]
    public PaginationDto  Pagination {get;set;}
    /// <summary>
    ///  是否获取自定义数据
    /// </summary>
    [JsonProperty("withCustomData")]
    public bool  WithCustomData {get;set;}
    /// <summary>
    ///  是否获取 identities
    /// </summary>
    [JsonProperty("withIdentities")]
    public bool  WithIdentities {get;set;}
    /// <summary>
    ///  是否获取部门 ID 列表
    /// </summary>
    [JsonProperty("withDepartmentIds")]
    public bool  WithDepartmentIds {get;set;}
}
}