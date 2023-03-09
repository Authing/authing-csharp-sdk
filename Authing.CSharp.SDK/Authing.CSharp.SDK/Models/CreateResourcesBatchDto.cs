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
    /// CreateResourcesBatchDto 的模型
    /// </summary>
    public partial class CreateResourcesBatchDto
    {
        /// <summary>
        ///  资源列表
        /// </summary>
        [JsonProperty("list")]
        public List<CreateResourceBatchItemDto>  List  {get;set;}
        /// <summary>
        ///  所属权限分组(权限空间)的 Code
        /// </summary>
        [JsonProperty("namespace")]
        public string  Namespace  {get;set;}
    }
}