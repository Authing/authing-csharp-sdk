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
    /// DeletePipelineFunctionDto 的模型
    /// </summary>
    public partial class DeletePipelineFunctionDto
    {
        /// <summary>
        ///  Pipeline 函数 ID
        /// </summary>
        [JsonProperty("funcId")]
        public string  FuncId {get;set;}
    }
}