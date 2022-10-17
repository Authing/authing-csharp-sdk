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
/// CancelSyncRiskOperationDto 的模型
/// </summary>
public partial class CancelSyncRiskOperationDto
{
    /// <summary>
    ///  同步任务风险操作 ID
    /// </summary>
    [JsonProperty("syncRiskOperationIds")]
    public List<long>  SyncRiskOperationIds {get;set;}
}
}