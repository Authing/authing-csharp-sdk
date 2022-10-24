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
/// SyncTaskClientConfig 的模型
/// </summary>
public partial class SyncTaskClientConfig
{
    /// <summary>
    ///  飞书同步任务配置
    /// </summary>
    [JsonProperty("larkConfig")]
    public SyncTaskLarkClientConfig  LarkConfig {get;set;}
    /// <summary>
    ///  飞书(国际版)同步任务配置
    /// </summary>
    [JsonProperty("larkInternationalConfig")]
    public SyncTaskLarkClientConfig  LarkInternationalConfig {get;set;}
    /// <summary>
    ///  企业微信同步任务配置
    /// </summary>
    [JsonProperty("wechatworkConfig")]
    public SyncTaskWechatworkClientConfig  WechatworkConfig {get;set;}
    /// <summary>
    ///  钉钉同步任务配置
    /// </summary>
    [JsonProperty("dingtalkConfig")]
    public SyncTaskDingtalkClientConfig  DingtalkConfig {get;set;}
    /// <summary>
    ///  Moka 同步任务配置
    /// </summary>
    [JsonProperty("mokaConfig")]
    public SyncTaskMokaClientConfig  MokaConfig {get;set;}
    /// <summary>
    ///  自定义同步源同步任务配置
    /// </summary>
    [JsonProperty("scimConfig")]
    public SyncTaskScimClientConfig  ScimConfig {get;set;}
    /// <summary>
    ///  Windows AD 同步任务配置
    /// </summary>
    [JsonProperty("activeDirectoryConfig")]
    public SyncTaskActiveDirectoryClientConfig  ActiveDirectoryConfig {get;set;}
    /// <summary>
    ///  LDAP 同步任务配置
    /// </summary>
    [JsonProperty("ldapConfig")]
    public SyncTaskLdapClientConfig  LdapConfig {get;set;}
    /// <summary>
    ///  北森同步任务配置
    /// </summary>
    [JsonProperty("italentConfig")]
    public SyncTaskItalentClientConfig  ItalentConfig {get;set;}
    /// <summary>
    ///  每刻报销同步任务配置
    /// </summary>
    [JsonProperty("maycurConfig")]
    public SyncTaskMaycurClientConfig  MaycurConfig {get;set;}
    /// <summary>
    ///  纷享销客同步任务配置
    /// </summary>
    [JsonProperty("fxiaokeConfig")]
    public SyncTaskFxiaokeClientConfig  FxiaokeConfig {get;set;}
    /// <summary>
    ///  销售易同步任务配置
    /// </summary>
    [JsonProperty("xiaoshouyiConfig")]
    public SyncTaskXiaoshouyiClientConfig  XiaoshouyiConfig {get;set;}
    /// <summary>
    ///  嘉扬同步任务配置
    /// </summary>
    [JsonProperty("kayangConfig")]
    public SyncTaskKayangClientConfig  KayangConfig {get;set;}
}
}