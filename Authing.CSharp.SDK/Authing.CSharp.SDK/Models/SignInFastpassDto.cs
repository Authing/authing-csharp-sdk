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
    /// SignInFastpassDto 的模型
    /// </summary>
    public partial class SignInFastpassDto
    {
        /// <summary>
        ///  可选参数
        /// </summary>
        [JsonProperty("options")]
        public SignInFastpassOptionsDto  Options  {get;set;}
    }
}