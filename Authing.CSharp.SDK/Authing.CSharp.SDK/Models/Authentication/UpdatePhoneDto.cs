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
    /// UpdatePhoneDto 的模型
    /// </summary>
    public partial class UpdatePhoneDto
    {
        /// <summary>
        ///  用于临时修改手机号的 token，可从**发起修改手机号的验证请求**接口获取。
        /// </summary>
        [JsonProperty("updatePhoneToken")]
        public string UpdatePhoneToken { get; set; }
    }
}