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
    /// InviteTenantUserRecordListDto 的模型
    /// </summary>
    public partial class InviteTenantUserRecordListDto
    {
        /// <summary>
        ///  记录总数
        /// </summary>
        [JsonProperty("totalCount")]
        public long  TotalCount {get;set;}
        /// <summary>
        ///  邀请用户历史记录
        /// </summary>
        [JsonProperty("list")]
        public List<InviteTenantUserRecord>  List {get;set;}
    }
}