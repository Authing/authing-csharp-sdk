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
    /// GetSyncTaskDto 的模型
    /// </summary>
    public partial class GetSyncTaskDto
    {
        /// <summary>
        ///  同步任务 ID
        /// </summary>
        [JsonProperty("syncTaskId")]
        public long  SyncTaskId {get;set;} 
    }
}