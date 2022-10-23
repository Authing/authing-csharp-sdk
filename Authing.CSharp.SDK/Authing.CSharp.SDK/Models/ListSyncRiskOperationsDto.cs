using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


   namespace Authing.CSharp.SDK.Models
{
/// <summary>
/// ListSyncRiskOperationsDto 的模型
/// </summary>
public partial class ListSyncRiskOperationsDto
{
    /// <summary>
    ///  同步任务 ID
    /// </summary>
    [JsonProperty("syncTaskId")]
    public long  SyncTaskId {get;set;} 
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
    /// <summary>
    ///  根据执行状态筛选
    /// </summary>
    [JsonProperty("status")]
    public string  Status {get;set;} 
    /// <summary>
    ///  根据操作对象类型，默认获取所有类型的记录：
/// - `department`: 部门
/// - `user`: 用户
/// 
    /// </summary>
    [JsonProperty("objectType")]
    public string  ObjectType {get;set;} 
}
}