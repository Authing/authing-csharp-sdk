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
/// CreateSyncTaskDto 的模型
/// </summary>
public partial class CreateSyncTaskDto
{
    /// <summary>
    ///  字段映射配置
    /// </summary>
    [JsonProperty("fieldMapping")]
    public List<SyncTaskFieldMapping>  FieldMapping {get;set;}
    /// <summary>
    ///  同步任务触发类型：
/// - `manually`: 手动触发执行
/// - `timed`: 定时触发
/// - `automatic`: 根据事件自动触发
/// 
    /// </summary>
    [JsonProperty("syncTaskTrigger")]
    public syncTaskTrigger  SyncTaskTrigger {get;set;}
    /// <summary>
    ///  同步任务数据流向：
/// - `upstream`: 作为上游，将数据同步到 Authing
/// - `downstream`: 作为下游，将 Authing 数据同步到此系统
/// 
    /// </summary>
    [JsonProperty("syncTaskFlow")]
    public syncTaskFlow  SyncTaskFlow {get;set;}
    /// <summary>
    ///  同步任务配置信息
    /// </summary>
    [JsonProperty("clientConfig")]
    public SyncTaskClientConfig  ClientConfig {get;set;}
    /// <summary>
    ///  同步任务类型:
/// - `lark`: 飞书
/// - `lark-international`: 飞书国际版
/// - `wechatwork`: 企业微信
/// - `dingtalk`: 钉钉
/// - `active-directory`: Windows AD
/// - `ldap`: LDAP
/// - `italent`: 北森
/// - `maycur`: 每刻报销
/// - `moka`: Moka
/// - `fxiaoke`: 纷享销客
/// - `xiaoshouyi`: 销售易
/// - `kayang`: 嘉扬 HR
/// - `scim`: 自定义同步源
/// 
    /// </summary>
    [JsonProperty("syncTaskType")]
    public syncTaskType  SyncTaskType {get;set;}
    /// <summary>
    ///  同步任务名称
    /// </summary>
    [JsonProperty("syncTaskName")]
    public string  SyncTaskName {get;set;}
    /// <summary>
    ///  此同步任务绑定的组织机构。针对上游同步，需执行一次同步任务之后才会绑定组织机构；针对下游同步，创建同步任务的时候就需要设置。
    /// </summary>
    [JsonProperty("organizationCode")]
    public string  OrganizationCode {get;set;}
    /// <summary>
    ///  同步范围，**只针对下游同步任务有效**。为空表示同步整个组织机构。
    /// </summary>
    [JsonProperty("provisioningScope")]
    public SyncTaskProvisioningScope  ProvisioningScope {get;set;}
    /// <summary>
    ///  定时同步时间设置
    /// </summary>
    [JsonProperty("timedScheduler")]
    public SyncTaskTimedScheduler  TimedScheduler {get;set;}
}
public partial class CreateSyncTaskDto
 {
    /// <summary>
    ///  同步任务类型:
/// - `lark`: 飞书
/// - `lark-international`: 飞书国际版
/// - `wechatwork`: 企业微信
/// - `dingtalk`: 钉钉
/// - `active-directory`: Windows AD
/// - `ldap`: LDAP
/// - `italent`: 北森
/// - `maycur`: 每刻报销
/// - `moka`: Moka
/// - `fxiaoke`: 纷享销客
/// - `xiaoshouyi`: 销售易
/// - `kayang`: 嘉扬 HR
/// - `scim`: 自定义同步源
/// 
    /// </summary>
    public enum syncTaskType
     {
         [EnumMember(Value="lark")]
        LARK,
         [EnumMember(Value="lark-international")]
        LARK_INTERNATIONAL,
         [EnumMember(Value="wechatwork")]
        WECHATWORK,
         [EnumMember(Value="dingtalk")]
        DINGTALK,
         [EnumMember(Value="active-directory")]
        ACTIVE_DIRECTORY,
         [EnumMember(Value="italent")]
        ITALENT,
         [EnumMember(Value="maycur")]
        MAYCUR,
         [EnumMember(Value="ldap")]
        LDAP,
         [EnumMember(Value="moka")]
        MOKA,
         [EnumMember(Value="fxiaoke")]
        FXIAOKE,
         [EnumMember(Value="scim")]
        SCIM,
         [EnumMember(Value="xiaoshouyi")]
        XIAOSHOUYI,
         [EnumMember(Value="kayang")]
        KAYANG,
         [EnumMember(Value="custom")]
        CUSTOM,
    }
    /// <summary>
    ///  同步任务数据流向：
/// - `upstream`: 作为上游，将数据同步到 Authing
/// - `downstream`: 作为下游，将 Authing 数据同步到此系统
/// 
    /// </summary>
    public enum syncTaskFlow
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
    public enum syncTaskTrigger
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