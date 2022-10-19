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
/// GetUserActionLogsDto 的模型
/// </summary>
public partial class GetUserActionLogsDto
{
    /// <summary>
    ///  请求 ID
    /// </summary>
    [JsonProperty("requestId")]
    public string  RequestId {get;set;}
    /// <summary>
    ///  客户端 IP
    /// </summary>
    [JsonProperty("clientIp")]
    public string  ClientIp {get;set;}
    /// <summary>
    ///  事件类型
    /// </summary>
    [JsonProperty("eventType")]
    public string  EventType {get;set;}
    /// <summary>
    ///  用户 ID
    /// </summary>
    [JsonProperty("userId")]
    public string  UserId {get;set;}
    /// <summary>
    ///  应用 ID
    /// </summary>
    [JsonProperty("appId")]
    public string  AppId {get;set;}
    /// <summary>
    ///  开始时间戳
    /// </summary>
    [JsonProperty("start")]
    public long  Start {get;set;}
    /// <summary>
    ///  结束时间戳
    /// </summary>
    [JsonProperty("end")]
    public long  End {get;set;}
    /// <summary>
    ///  请求是否成功
    /// </summary>
    [JsonProperty("success")]
    public bool  Success {get;set;}
    /// <summary>
    ///  分页
    /// </summary>
    [JsonProperty("pagination")]
    public ListWebhooksDto  Pagination {get;set;}
}
}