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
    /// TriggerSyncTaskDataDto 的模型
    /// </summary>
    public partial class TriggerSyncTaskDataDto
    {
        /// <summary>
        ///  此次执行同步任务的同步作业 ID
        /// </summary>
        [JsonProperty("syncJobId")]
        public long  SyncJobId  {get;set;}
    }
}