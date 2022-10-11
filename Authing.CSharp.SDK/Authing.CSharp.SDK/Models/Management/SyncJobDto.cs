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
/// SyncJobDto 的模型
/// </summary>
public partial class SyncJobDto
{
    /// <summary>
    ///  同步作业 ID
    /// </summary>
[JsonProperty("syncJobId")]
public    long   SyncJobId    {get;set;}
    /// <summary>
    ///  此同步作业对应的同步任务 ID
    /// </summary>
[JsonProperty("syncTaskId")]
public    long   SyncTaskId    {get;set;}
    /// <summary>
    ///  创建时间
    /// </summary>
[JsonProperty("createdAt")]
public    string   CreatedAt    {get;set;}
    /// <summary>
    ///  更新时间
    /// </summary>
[JsonProperty("updatedAt")]
public    string   UpdatedAt    {get;set;}
    /// <summary>
    ///  当前同步状态:
/// - `free`: 空闲状态，从未执行
/// - `pending`: 等待系统执行
/// - `onProgress`: 正在执行
/// - `success`: 成功
/// - `failed`: 失败
/// 
    /// </summary>
[JsonProperty("syncStatus")]
public    syncStatus   SyncStatus    {get;set;}
    /// <summary>
    ///  同步任务数据流向：
/// - `upstream`: 作为上游，将数据同步到 Authing
/// - `downstream`: 作为下游，将 Authing 数据同步到此系统
/// 
    /// </summary>
[JsonProperty("syncFlow")]
public    syncFlow   SyncFlow    {get;set;}
    /// <summary>
    ///  同步任务触发类型：
/// - `manually`: 手动触发执行
/// - `timed`: 定时触发
/// - `automatic`: 根据事件自动触发
/// 
    /// </summary>
[JsonProperty("syncTrigger")]
public    syncTrigger   SyncTrigger    {get;set;}
    /// <summary>
    ///  需要同步的部门个数
    /// </summary>
[JsonProperty("departmentCountAll")]
public    long   DepartmentCountAll    {get;set;}
    /// <summary>
    ///  成功同步的部门个数
    /// </summary>
[JsonProperty("departmentCountSucc")]
public    long   DepartmentCountSucc    {get;set;}
    /// <summary>
    ///  需要更新的部门个数
    /// </summary>
[JsonProperty("departmentUpdateCountAll")]
public    long   DepartmentUpdateCountAll    {get;set;}
    /// <summary>
    ///  成功更新的部门个数
    /// </summary>
[JsonProperty("departmentUpdateCountSucc")]
public    long   DepartmentUpdateCountSucc    {get;set;}
    /// <summary>
    ///  需要同步的用户个数
    /// </summary>
[JsonProperty("accountCountAll")]
public    long   AccountCountAll    {get;set;}
    /// <summary>
    ///  成功同步的用户个数
    /// </summary>
[JsonProperty("accountCountSucc")]
public    long   AccountCountSucc    {get;set;}
    /// <summary>
    ///  需要更新的用户个数
    /// </summary>
[JsonProperty("accountUpdateCountAll")]
public    long   AccountUpdateCountAll    {get;set;}
    /// <summary>
    ///  成功更新的用户个数
    /// </summary>
[JsonProperty("accountUpdateCountSucc")]
public    long   AccountUpdateCountSucc    {get;set;}
    /// <summary>
    ///  错误信息
    /// </summary>
[JsonProperty("errMsg")]
public    string   ErrMsg    {get;set;}
}
public partial class SyncJobDto
 {
    /// <summary>
    ///  当前同步状态:
/// - `free`: 空闲状态，从未执行
/// - `pending`: 等待系统执行
/// - `onProgress`: 正在执行
/// - `success`: 成功
/// - `failed`: 失败
/// 
    /// </summary>
    public enum syncStatus
     {
         [EnumMember(Value="free")]
        FREE,
         [EnumMember(Value="pending")]
        PENDING,
         [EnumMember(Value="onProgress")]
        ON_PROGRESS,
         [EnumMember(Value="success")]
        SUCCESS,
         [EnumMember(Value="failed")]
        FAILED,
    }
    /// <summary>
    ///  同步任务数据流向：
/// - `upstream`: 作为上游，将数据同步到 Authing
/// - `downstream`: 作为下游，将 Authing 数据同步到此系统
/// 
    /// </summary>
    public enum syncFlow
     {
         [EnumMember(Value="upstream")]
        UPSTREAM,
         [EnumMember(Value="downstream")]
        DOWNSTREAM,
    }
    /// <summary>
    ///  同步任务触发类型：
/// - `manually`: 手动触发执行
/// - `timed`: 定时触发
/// - `automatic`: 根据事件自动触发
/// 
    /// </summary>
    public enum syncTrigger
     {
         [EnumMember(Value="manually")]
        MANUALLY,
         [EnumMember(Value="timed")]
        TIMED,
         [EnumMember(Value="automatic")]
        AUTOMATIC,
    }
}
}