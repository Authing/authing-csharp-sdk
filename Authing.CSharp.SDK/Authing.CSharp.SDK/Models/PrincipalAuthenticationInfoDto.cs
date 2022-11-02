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
    /// PrincipalAuthenticationInfoDto 的模型
    /// </summary>
    public partial class PrincipalAuthenticationInfoDto
    {
        /// <summary>
        ///  是否进行认证
        /// </summary>
        [JsonProperty("authenticated")]
        public bool  Authenticated {get;set;}
        /// <summary>
        ///  用户 ID
        /// </summary>
        [JsonProperty("principalType")]
        public string  PrincipalType {get;set;}
        /// <summary>
        ///  认证主体证件号码
        /// </summary>
        [JsonProperty("principalCode")]
        public string  PrincipalCode {get;set;}
        /// <summary>
        ///  认证主体名称
        /// </summary>
        [JsonProperty("principalName")]
        public string  PrincipalName {get;set;}
        /// <summary>
        ///  认证时间，标准时间字符串
        /// </summary>
        [JsonProperty("authenticatedAt")]
        public string  AuthenticatedAt {get;set;}
    }
}