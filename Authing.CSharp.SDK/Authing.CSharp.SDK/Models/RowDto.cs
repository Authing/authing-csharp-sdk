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
    /// RowDto 的模型
    /// </summary>
    public partial class RowDto
    {
        /// <summary>
        ///  行 id
        /// </summary>
        [JsonProperty("rowId")]
        public string  RowId {get;set;}
        /// <summary>
        ///  单元格列表
        /// </summary>
        [JsonProperty("cellList")]
        public List<CellDto>  CellList {get;set;}
    }
}