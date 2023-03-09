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
    /// DeletePermissionNamespaceDto 的模型
    /// </summary>
    public partial class DeletePermissionNamespaceDto
    {
        /// <summary>
        ///  权限空间 Code
        /// </summary>
        [JsonProperty("code")]
        public string  Code  {get;set;}
    }
}