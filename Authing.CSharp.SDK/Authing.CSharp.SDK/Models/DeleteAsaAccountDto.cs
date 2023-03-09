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
    /// DeleteAsaAccountDto 的模型
    /// </summary>
    public partial class DeleteAsaAccountDto
    {
        /// <summary>
        ///  ASA 账号 ID
        /// </summary>
        [JsonProperty("accountId")]
        public string  AccountId  {get;set;}
        /// <summary>
        ///  所属应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public string  AppId  {get;set;}
    }
}