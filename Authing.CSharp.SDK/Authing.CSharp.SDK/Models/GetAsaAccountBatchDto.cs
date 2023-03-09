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
    /// GetAsaAccountBatchDto 的模型
    /// </summary>
    public partial class GetAsaAccountBatchDto
    {
        /// <summary>
        ///  ASA 账号 ID 列表
        /// </summary>
        [JsonProperty("accountIds")]
        public List<string>  AccountIds  {get;set;}
        /// <summary>
        ///  所属应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public string  AppId  {get;set;}
    }
}