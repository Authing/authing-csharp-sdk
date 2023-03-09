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
    /// GetUserResourcePermissionList 的模型
    /// </summary>
    public partial class GetUserResourcePermissionList
    {
        /// <summary>
        ///  权限空间 code
        /// </summary>
        [JsonProperty("namespaceCode")]
        public string  NamespaceCode  {get;set;}
        /// <summary>
        ///  数据资源权限操作列表
        /// </summary>
        [JsonProperty("actions")]
        public List<string>  Actions  {get;set;}
        /// <summary>
        ///  资源路径
        /// </summary>
        [JsonProperty("resource")]
        public string  Resource  {get;set;}
    }
}