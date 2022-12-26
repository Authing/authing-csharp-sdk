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
    /// GetAsaAccountDto 的模型
    /// </summary>
    public partial class GetAsaAccountDto
    {
        /// <summary>
        ///  所属应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public string  AppId {get;set;} 
        /// <summary>
        ///  ASA 账号 ID
        /// </summary>
        [JsonProperty("accountId")]
        public string  AccountId {get;set;} 
    }
}