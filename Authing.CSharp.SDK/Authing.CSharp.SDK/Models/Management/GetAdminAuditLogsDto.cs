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
/// GetAdminAuditLogsDto 的模型
/// </summary>
public partial class GetAdminAuditLogsDto
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
    ///  操作类型
    /// </summary>
    [JsonProperty("operationType")]
    public string  OperationType {get;set;}
    /// <summary>
    ///  资源类型
    /// </summary>
    [JsonProperty("resourceType")]
    public string  ResourceType {get;set;}
    /// <summary>
    ///  管理员用户 ID
    /// </summary>
    [JsonProperty("userId")]
    public string  UserId {get;set;}
    /// <summary>
    ///  请求是否成功
    /// </summary>
    [JsonProperty("success")]
    public bool  Success {get;set;}
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
    ///  分页
    /// </summary>
    [JsonProperty("pagination")]
    public ListWebhooksDto  Pagination {get;set;}
}
}