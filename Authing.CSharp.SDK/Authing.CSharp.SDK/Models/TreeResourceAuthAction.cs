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
    /// TreeResourceAuthAction 的模型
    /// </summary>
    public partial class TreeResourceAuthAction
    {
        /// <summary>
        ///  树结构节点列表
        /// </summary>
        [JsonProperty("nodeAuthActionList")]
        public List<TreeStructs>  NodeAuthActionList  {get;set;}
    }
}