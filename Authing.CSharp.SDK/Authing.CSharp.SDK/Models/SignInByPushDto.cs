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
    /// SignInByPushDto 的模型
    /// </summary>
    public partial class SignInByPushDto
    {
        /// <summary>
        ///  用户账号（用户名/手机号/邮箱）
        /// </summary>
        [JsonProperty("account")]
        public string  Account  {get;set;}
        /// <summary>
        ///  可选参数
        /// </summary>
        [JsonProperty("options")]
        public SignInByPushOptionsDto  Options  {get;set;}
    }
}