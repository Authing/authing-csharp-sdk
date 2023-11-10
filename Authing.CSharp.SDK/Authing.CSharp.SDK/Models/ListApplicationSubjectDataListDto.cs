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
    /// ListApplicationSubjectDataListDto 的模型
    /// </summary>
    public partial class ListApplicationSubjectDataListDto
    {
        /// <summary>
        ///  列表数据
        /// </summary>
        [JsonProperty("list")]
        public List<ListApplicationSubjectDataDto>  List {get;set;}
    }
}