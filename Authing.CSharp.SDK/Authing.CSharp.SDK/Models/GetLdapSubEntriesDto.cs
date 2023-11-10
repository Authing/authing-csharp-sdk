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
    /// GetLdapSubEntriesDto 的模型
    /// </summary>
    public partial class GetLdapSubEntriesDto
    {
        /// <summary>
        ///  当前页,从 1 开始
        /// </summary>
        [JsonProperty("page")]
        public long  Page {get;set;} =1;
        /// <summary>
        ///  每页条数
        /// </summary>
        [JsonProperty("limit")]
        public long  Limit {get;set;} =10;
        /// <summary>
        ///  当前 DN
        /// </summary>
        [JsonProperty("dn")]
        public string  Dn {get;set;} 
    }
}