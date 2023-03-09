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
    /// AsaAccountPaginatedDataDto 的模型
    /// </summary>
    public partial class AsaAccountPaginatedDataDto
    {
        /// <summary>
        ///  列表数据
        /// </summary>
        [JsonProperty("list")]
        public List<AsaAccountDto>  List  {get;set;}
        /// <summary>
        ///  记录总数
        /// </summary>
        [JsonProperty("totalCount")]
        public long  TotalCount  {get;set;}
    }
}