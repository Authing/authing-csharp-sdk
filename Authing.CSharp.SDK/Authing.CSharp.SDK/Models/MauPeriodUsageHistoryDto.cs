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
/// MauPeriodUsageHistoryDto 的模型
/// </summary>
public partial class MauPeriodUsageHistoryDto
{
    /// <summary>
    ///  周期开始时间(年月日)
    /// </summary>
    [JsonProperty("periodStartTime")]
    public string  PeriodStartTime {get;set;}
    /// <summary>
    ///  周期结束时间(年月日)
    /// </summary>
    [JsonProperty("periodEndTime")]
    public string  PeriodEndTime {get;set;}
    /// <summary>
    ///  当前周期使用的 mau 总数量
    /// </summary>
    [JsonProperty("amount")]
    public string  Amount {get;set;}
    /// <summary>
    ///  当前周期使用的 mau 数量
    /// </summary>
    [JsonProperty("current")]
    public string  Current {get;set;}
}
}