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
/// TriggerSyncRiskOperationsDataDto 的模型
/// </summary>
public partial class TriggerSyncRiskOperationsDataDto
{
    /// <summary>
    ///  成功执行的风险操作任务
    /// </summary>
    [JsonProperty("successList")]
    public List<long>  SuccessList {get;set;}
    /// <summary>
    ///  执行失败的风险操作任务
    /// </summary>
    [JsonProperty("faildList")]
    public List<long>  FaildList {get;set;}
}
}