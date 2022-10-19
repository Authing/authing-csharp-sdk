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
/// ListSyncJobsDto 的模型
/// </summary>
public partial class ListSyncJobsDto
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
    ///  同步任务触发类型：
/// - `manually`: 手动触发执行
/// - `timed`: 定时触发
/// - `automatic`: 根据事件自动触发
/// 
    /// </summary>
    [JsonProperty("syncTrigger")]
    public string  SyncTrigger {get;set;} 
}
}