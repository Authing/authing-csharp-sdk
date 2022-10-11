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
    /// GetApplicationPublicConfigDto 的模型
    /// </summary>
    public partial class GetApplicationPublicConfigDto
    {
        /// <summary>
        ///  应用 ID，可选，默认会从请求的域名获取对应的应用
        /// </summary>
        [JsonProperty("appId")]
        public    object   AppId    {get;set;}
    }
}