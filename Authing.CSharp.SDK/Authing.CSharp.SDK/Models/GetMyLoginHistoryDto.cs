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
/// GetMyLoginHistoryDto 的模型
/// </summary>
public partial class GetMyLoginHistoryDto
{
    /// <summary>
    ///  应用 ID，可根据应用 ID 筛选。默认不传获取所有应用的登录历史。
    /// </summary>
    [JsonProperty("appId")]
    public string  AppId {get;set;} 
    /// <summary>
    ///  客户端 IP，可根据登录时的客户端 IP 进行筛选。默认不传获取所有登录 IP 的登录历史。
    /// </summary>
    [JsonProperty("clientIp")]
    public string  ClientIp {get;set;} 
    /// <summary>
    ///  是否登录成功，可根据是否登录成功进行筛选。默认不传获取的记录中既包含成功也包含失败的的登录历史。
    /// </summary>
    [JsonProperty("success")]
    public bool  Success {get;set;} 
    /// <summary>
    ///  开始时间，为单位为毫秒的时间戳
    /// </summary>
    [JsonProperty("start")]
    public long  Start {get;set;} 
    /// <summary>
    ///  结束时间，为单位为毫秒的时间戳
    /// </summary>
    [JsonProperty("end")]
    public long  End {get;set;} 
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
}
}