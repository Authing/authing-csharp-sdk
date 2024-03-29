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
    /// LdapLogDto 的模型
    /// </summary>
    public partial class LdapLogDto
    {
        /// <summary>
        ///  总数
        /// </summary>
        [JsonProperty("totalCount")]
        public long  TotalCount {get;set;}
        /// <summary>
        ///  记录数据
        /// </summary>
        [JsonProperty("list")]
        public object  List {get;set;}
    }
}