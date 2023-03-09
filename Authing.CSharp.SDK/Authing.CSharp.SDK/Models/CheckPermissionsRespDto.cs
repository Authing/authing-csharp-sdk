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
    /// CheckPermissionsRespDto 的模型
    /// </summary>
    public partial class CheckPermissionsRespDto
    {
        /// <summary>
        ///  权限空间 Code
        /// </summary>
        [JsonProperty("namespaceCode")]
        public string  NamespaceCode  {get;set;}
        /// <summary>
        ///  数据资源权限操作
        /// </summary>
        [JsonProperty("action")]
        public string  Action  {get;set;}
        /// <summary>
        ///  资源路径
        /// </summary>
        [JsonProperty("resource")]
        public string  Resource  {get;set;}
        /// <summary>
        ///  用户在某个权限空间下是否具有该数据资源的某个操作
        /// </summary>
        [JsonProperty("enabled")]
        public bool  Enabled  {get;set;}
    }
}