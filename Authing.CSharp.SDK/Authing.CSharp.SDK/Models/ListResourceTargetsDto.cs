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
    /// ListResourceTargetsDto 的模型
    /// </summary>
    public partial class ListResourceTargetsDto
    {
        /// <summary>
        ///  数据策略所属的数据资源路径列表
        /// </summary>
        [JsonProperty("resources")]
        public List<string>  Resources  {get;set;}
        /// <summary>
        ///  数据资源权限操作列表
        /// </summary>
        [JsonProperty("actions")]
        public List<string>  Actions  {get;set;}
        /// <summary>
        ///  权限空间 Code
        /// </summary>
        [JsonProperty("namespaceCode")]
        public string  NamespaceCode  {get;set;}
    }
}