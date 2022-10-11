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
    /// GetSecurityInfoDto 的模型
    /// </summary>
    public partial class GetSecurityInfoDto
    {
        /// <summary>
        ///  密码强度等级
        /// </summary>
        [JsonProperty("passwordSecurityLevel")]
        public    long   PasswordSecurityLevel    {get;set;}
        /// <summary>
        ///  是否绑定了 MFA
        /// </summary>
        [JsonProperty("mfaEnrolled")]
        public    bool   MfaEnrolled    {get;set;}
        /// <summary>
        ///  是否设置了密码
        /// </summary>
        [JsonProperty("passwordSet")]
        public    bool   PasswordSet    {get;set;}
        /// <summary>
        ///  是否绑定了邮箱
        /// </summary>
        [JsonProperty("emailBinded")]
        public    bool   EmailBinded    {get;set;}
        /// <summary>
        ///  是否绑定了手机号
        /// </summary>
        [JsonProperty("phoneBinded")]
        public    bool   PhoneBinded    {get;set;}
        /// <summary>
        ///  账号等级评分
        /// </summary>
        [JsonProperty("securityScore")]
        public    long   SecurityScore    {get;set;}
    }
}