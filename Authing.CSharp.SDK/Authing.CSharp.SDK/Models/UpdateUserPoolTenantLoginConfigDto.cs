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
    /// UpdateUserPoolTenantLoginConfigDto 的模型
    /// </summary>
    public partial class UpdateUserPoolTenantLoginConfigDto
    {
        /// <summary>
        ///  应用登录配置更新内容
        /// </summary>
        [JsonProperty("update")]
        public UpdateLoginConfig  Update {get;set;}
    }
}