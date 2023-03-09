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
    /// GetPostByIdListDto 的模型
    /// </summary>
    public partial class GetPostByIdListDto
    {
        /// <summary>
        ///  部门 id 列表
        /// </summary>
        [JsonProperty("idList")]
        public List<string>  IdList  {get;set;}
    }
}