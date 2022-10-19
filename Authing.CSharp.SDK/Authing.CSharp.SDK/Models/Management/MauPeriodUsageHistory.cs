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
/// MauPeriodUsageHistory 的模型
/// </summary>
public partial class MauPeriodUsageHistory
{
    /// <summary>
    ///  响应数据
    /// </summary>
    [JsonProperty("records")]
    public List<MauPeriodUsageHistoryDto>  Records {get;set;}
}
}