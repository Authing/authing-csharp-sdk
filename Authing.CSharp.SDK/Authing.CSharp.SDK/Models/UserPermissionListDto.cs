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
    /// UserPermissionListDto 的模型
    /// </summary>
    public partial class UserPermissionListDto
    {
        /// <summary>
        ///  数据策略授权的用户 ID
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId  {get;set;}
        /// <summary>
        ///  数据策略授权的权限空间 Code
        /// </summary>
        [JsonProperty("namespaceCode")]
        public string  NamespaceCode  {get;set;}
        /// <summary>
        ///  用户在权限空间下所有的数据策略资源列表
        /// </summary>
        [JsonProperty("resourceList")]
        public List<OpenResource>  ResourceList  {get;set;}
    }
}