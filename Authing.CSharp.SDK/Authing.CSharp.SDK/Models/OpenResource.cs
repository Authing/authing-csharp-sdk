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
    /// OpenResource 的模型
    /// </summary>
    public partial class OpenResource
    {
        /// <summary>
        ///  数据策略下所授权的数据资源 Code
        /// </summary>
        [JsonProperty("resourceCode")]
        public string  ResourceCode {get;set;}
        /// <summary>
        ///  用户在权限空间下所有的数据策略的资源列表
        /// </summary>
        [JsonProperty("authorize")]
        public object  Authorize {get;set;}
    }
}