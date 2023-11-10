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
    /// InviteTenantUserRecord 的模型
    /// </summary>
    public partial class InviteTenantUserRecord
    {
        /// <summary>
        ///  邀请记录编号
        /// </summary>
        [JsonProperty("recordId")]
        public long  RecordId {get;set;}
        /// <summary>
        ///  邀请账号
        /// </summary>
        [JsonProperty("inviteAccount")]
        public string  InviteAccount {get;set;}
        /// <summary>
        ///  账号激活状态
        /// </summary>
        [JsonProperty("verifiedStatus")]
        public string  VerifiedStatus {get;set;}
        /// <summary>
        ///  邀请链接
        /// </summary>
        [JsonProperty("inviteLink")]
        public string  InviteLink {get;set;}
        /// <summary>
        ///  创建时间
        /// </summary>
        [JsonProperty("createdAt")]
        public string  CreatedAt {get;set;}
        /// <summary>
        ///  账号激活时间
        /// </summary>
        [JsonProperty("activatedAt")]
        public string  ActivatedAt {get;set;}
    }
}