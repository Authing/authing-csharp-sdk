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
    /// GetUserPermissionListDto 的模型
    /// </summary>
    public partial class GetUserPermissionListDto
    {
        /// <summary>
        ///  用户 ID 列表
        /// </summary>
        [JsonProperty("userIds")]
        public List<string>  UserIds  {get;set;}
        /// <summary>
        ///  权限空间 Code 列表
        /// </summary>
        [JsonProperty("namespaceCodes")]
        public List<string>  NamespaceCodes  {get;set;}
    }
}