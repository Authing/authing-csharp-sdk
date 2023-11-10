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
    /// ChangeUserPoolTenantExtIdpConnDto 的模型
    /// </summary>
    public partial class ChangeUserPoolTenantExtIdpConnDto
    {
        /// <summary>
        ///  是否开启身份源连接
        /// </summary>
        [JsonProperty("enabled")]
        public bool  Enabled {get;set;}
        /// <summary>
        ///  身份源连接 ID
        /// </summary>
        [JsonProperty("connIds")]
        public List<string>  ConnIds {get;set;}
    }
}