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
    /// DeleteCommonResourcesBatchDto 的模型
    /// </summary>
    public partial class DeleteCommonResourcesBatchDto
    {
        /// <summary>
        ///  资源 id 列表
        /// </summary>
        [JsonProperty("ids")]
        public List<string>  Ids  {get;set;}
    }
}