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
    /// NodeBo 的模型
    /// </summary>
    public partial class NodeBo
    {
        /// <summary>
        ///  组织机构 id
        /// </summary>
        [JsonProperty("nodeId")]
        public string  NodeId {get;set;}
        /// <summary>
        ///  组织机构名称
        /// </summary>
        [JsonProperty("nodeName")]
        public string  NodeName {get;set;}
        /// <summary>
        ///  组织机构 Code
        /// </summary>
        [JsonProperty("nodeCode")]
        public string  NodeCode {get;set;}
    }
}