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
/// GetSyncJobDto 的模型
/// </summary>
public partial class GetSyncJobDto
{
    /// <summary>
    ///  同步作业 ID
    /// </summary>
    [JsonProperty("syncJobId")]
    public long  SyncJobId {get;set;} 
}
}