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
/// RegisterAnomalyDetectionConfigDto 的模型
/// </summary>
public partial class RegisterAnomalyDetectionConfigDto
{
    /// <summary>
    ///  是否开启频繁注册限制
    /// </summary>
    [JsonProperty("enabled")]
    public bool  Enabled {get;set;}
    /// <summary>
    ///  在一定时间周期内，对于同一个 IP，最多只能注册多少次。
    /// </summary>
    [JsonProperty("limit")]
    public long  Limit {get;set;}
    /// <summary>
    ///  限定周期时间长度，单位为秒。
    /// </summary>
    [JsonProperty("timeInterval")]
    public long  TimeInterval {get;set;}
}
}