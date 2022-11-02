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
    /// GetMauPeriodUsageHistoryDto 的模型
    /// </summary>
    public partial class GetMauPeriodUsageHistoryDto
    {
        /// <summary>
        ///  起始时间（年月日）
        /// </summary>
        [JsonProperty("startTime")]
        public string  StartTime {get;set;} 
        /// <summary>
        ///  截止时间（年月日）
        /// </summary>
        [JsonProperty("endTime")]
        public string  EndTime {get;set;} 
    }
}