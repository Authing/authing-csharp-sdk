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
    /// TreeStructs 的模型
    /// </summary>
    public partial class TreeStructs
    {
        /// <summary>
        ///  树资源节点 Code, 同层级唯一
        /// </summary>
        [JsonProperty("code")]
        public string  Code  {get;set;}
        /// <summary>
        ///  树资源节点名称 ，同层级唯一
        /// </summary>
        [JsonProperty("name")]
        public string  Name  {get;set;}
        /// <summary>
        ///  树资源节点 Value
        /// </summary>
        [JsonProperty("value")]
        public string  Value  {get;set;}
        /// <summary>
        ///  树数据资源策略节点 actions 
        /// </summary>
        [JsonProperty("actions")]
        public List<string>  Actions  {get;set;}
        /// <summary>
        ///  子节点数据,子节点数据最多五个层级
        /// </summary>
        [JsonProperty("children")]
        public List<TreeStructs>  Children  {get;set;}
    }
}