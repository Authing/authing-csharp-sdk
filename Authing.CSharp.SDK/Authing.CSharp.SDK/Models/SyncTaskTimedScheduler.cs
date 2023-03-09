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
    /// SyncTaskTimedScheduler 的模型
    /// </summary>
    public partial class SyncTaskTimedScheduler
    {
        /// <summary>
        ///  定时周期：
/// - `month`: 每个月执行一次
/// - `week`: 每周执行一次
/// - `days`: 每天执行一次
/// - `sixHours`: 每六小时执行一次
/// - `twoHours`: 每两小时执行一次
/// 
        /// </summary>
        [JsonProperty("cycle")]
        public cycle  Cycle  {get;set;}
        /// <summary>
        ///  开始时间
        /// </summary>
        [JsonProperty("startTime")]
        public long  StartTime  {get;set;}
    }
    public partial class SyncTaskTimedScheduler
    {
        /// <summary>
        ///  定时周期：
/// - `month`: 每个月执行一次
/// - `week`: 每周执行一次
/// - `days`: 每天执行一次
/// - `sixHours`: 每六小时执行一次
/// - `twoHours`: 每两小时执行一次
/// 
        /// </summary>
        public enum cycle
        {
            [EnumMember(Value="month")]
            MONTH,
            [EnumMember(Value="week")]
            WEEK,
            [EnumMember(Value="days")]
            DAYS,
            [EnumMember(Value="sixHours")]
            SIX_HOURS,
            [EnumMember(Value="twoHours")]
            TWO_HOURS,
        }
    }
}