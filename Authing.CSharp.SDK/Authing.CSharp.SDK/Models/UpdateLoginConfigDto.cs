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
    /// UpdateLoginConfigDto 的模型
    /// </summary>
    public partial class UpdateLoginConfigDto
    {
        /// <summary>
        ///  应用登录配置更新内容
        /// </summary>
        [JsonProperty("update")]
        public UpdateLoginConfig  Update {get;set;}
    }
}