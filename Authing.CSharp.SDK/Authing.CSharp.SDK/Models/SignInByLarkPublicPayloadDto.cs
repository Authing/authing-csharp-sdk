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
    /// SignInByLarkPublicPayloadDto 的模型
    /// </summary>
    public partial class SignInByLarkPublicPayloadDto
    {
        /// <summary>
        ///  飞书应用商店应用移动端社会化登录返回的一次性临时 code
        /// </summary>
        [JsonProperty("code")]
        public string  Code  {get;set;}
    }
}