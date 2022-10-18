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
    /// ListArchivedUsersDto 的模型
    /// </summary>
    public partial class ListArchivedUsersDto
    {
        /// <summary>
        ///  当前页数，从 1 开始
        /// </summary>
        [JsonProperty("page")]
        public long Page { get; set; }
        /// <summary>
        ///  每页数目，最大不能超过 50，默认为 10
        /// </summary>
        [JsonProperty("limit")]
        public long Limit { get; set; }
        /// <summary>
        ///  开始时间，为精确到秒的 UNIX 时间戳，默认不指定
        /// </summary>
        [JsonProperty("startAt")]
        public long StartAt { get; set; }
    }
}