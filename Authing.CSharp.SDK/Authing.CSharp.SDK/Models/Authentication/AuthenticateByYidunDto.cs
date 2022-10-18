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
    /// AuthenticateByYidunDto 的模型
    /// </summary>
    public partial class AuthenticateByYidunDto
    {
        /// <summary>
        ///  网易易盾 token
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
        /// <summary>
        ///  网易易盾运营商授权码
        /// </summary>
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
    }
}