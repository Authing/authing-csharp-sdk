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
    /// AssignAsaAccountsDto 的模型
    /// </summary>
    public partial class AssignAsaAccountsDto
    {
        /// <summary>
        ///  所属应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public string  AppId {get;set;}
        /// <summary>
        ///  要关联的账号 ID
        /// </summary>
        [JsonProperty("accountId")]
        public string  AccountId {get;set;}
        /// <summary>
        ///  关联对象列表
        /// </summary>
        [JsonProperty("targets")]
        public List<AssignAsaAccountItem>  Targets {get;set;}
    }
}