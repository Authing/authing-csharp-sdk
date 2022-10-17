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
/// ListUsersDto 的模型
/// </summary>
public partial class ListUsersDto
{
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
    /// <summary>
    ///  账户当前状态，如 已停用、已离职、正常状态、已归档
    /// </summary>
    [JsonProperty("status")]
    public string  Status {get;set;}
    /// <summary>
    ///  用户创建、修改开始时间，为精确到秒的 UNIX 时间戳；支持获取从某一段时间之后的增量数据
    /// </summary>
    [JsonProperty("updatedAtStart")]
    public long  UpdatedAtStart {get;set;}
    /// <summary>
    ///  用户创建、修改终止时间，为精确到秒的 UNIX 时间戳；支持获取某一段时间内的增量数据。默认为当前时间
    /// </summary>
    [JsonProperty("updatedAtEnd")]
    public long  UpdatedAtEnd {get;set;}
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