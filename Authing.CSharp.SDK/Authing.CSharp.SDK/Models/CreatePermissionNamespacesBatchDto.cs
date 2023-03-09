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
    /// CreatePermissionNamespacesBatchDto 的模型
    /// </summary>
    public partial class CreatePermissionNamespacesBatchDto
    {
        /// <summary>
        ///  权限空间列表
        /// </summary>
        [JsonProperty("list")]
        public List<CreatePermissionNamespacesBatchItemDto>  List  {get;set;}
    }
}