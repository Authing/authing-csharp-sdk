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
/// SyncRiskOperationDto 的模型
/// </summary>
public partial class SyncRiskOperationDto
{
    /// <summary>
    ///  同步任务风险操作 ID
    /// </summary>
    [JsonProperty("syncRiskOperationId")]
    public long  SyncRiskOperationId {get;set;}
    /// <summary>
    ///  同步任务 ID
    /// </summary>
    [JsonProperty("syncTaskId")]
    public long  SyncTaskId {get;set;}
    /// <summary>
    ///  创建时间
    /// </summary>
    [JsonProperty("createdAt")]
    public string  CreatedAt {get;set;}
    /// <summary>
    ///  更新时间
    /// </summary>
    [JsonProperty("updatedAt")]
    public string  UpdatedAt {get;set;}
    /// <summary>
    ///  执行状态:
/// - `PENDING`: 待执行
/// - `SUCCESS`: 成功
/// - `FAILED`: 失败
/// - `CANCELED`: 已取消
/// - `EXECUTING`: 执行中
/// 
    /// </summary>
    [JsonProperty("status")]
    public status  Status {get;set;}
    /// <summary>
    ///  优先级，数字越小表示优先级越高。
    /// </summary>
    [JsonProperty("level")]
    public long  Level {get;set;}
    /// <summary>
    ///  操作对象类型:
/// - `department`: 部门
/// - `user`: 用户
/// 
    /// </summary>
    [JsonProperty("objectType")]
    public objectType  ObjectType {get;set;}
    /// <summary>
    ///  操作对象（用户、分组、部门）名称
    /// </summary>
    [JsonProperty("objectName")]
    public string  ObjectName {get;set;}
    /// <summary>
    ///  操作对象 ID
    /// </summary>
    [JsonProperty("objectId")]
    public string  ObjectId {get;set;}
    /// <summary>
    ///  执行失败的错误信息
    /// </summary>
    [JsonProperty("errMsg")]
    public string  ErrMsg {get;set;}
}
public partial class SyncRiskOperationDto
 {
    /// <summary>
    ///  执行状态:
/// - `PENDING`: 待执行
/// - `SUCCESS`: 成功
/// - `FAILED`: 失败
/// - `CANCELED`: 已取消
/// - `EXECUTING`: 执行中
/// 
    /// </summary>
    public enum status
     {
         [EnumMember(Value="PENDING")]
        PENDING,
         [EnumMember(Value="SUCCESS")]
        SUCCESS,
         [EnumMember(Value="FAILED")]
        FAILED,
         [EnumMember(Value="CANCELED")]
        CANCELED,
         [EnumMember(Value="EXECUTING")]
        EXECUTING,
    }
    /// <summary>
    ///  操作对象类型:
/// - `department`: 部门
/// - `user`: 用户
/// 
    /// </summary>
    public enum objectType
     {
         [EnumMember(Value="DEPARTMENT")]
        DEPARTMENT,
         [EnumMember(Value="USER")]
        USER,
    }
}
}