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
    /// DepartmentPagingDto 的模型
    /// </summary>
    public partial class DepartmentPagingDto
    {
        /// <summary>
        ///  总数
        /// </summary>
        [JsonProperty("totalCount")]
        public int  TotalCount {get;set;}
        /// <summary>
        ///  响应数据
        /// </summary>
        [JsonProperty("list")]
        public List<DepartmentDto>  List {get;set;}
    }
}