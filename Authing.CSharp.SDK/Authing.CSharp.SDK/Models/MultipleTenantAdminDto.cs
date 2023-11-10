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
    /// MultipleTenantAdminDto 的模型
    /// </summary>
    public partial class MultipleTenantAdminDto
    {
        /// <summary>
        ///  用户唯一 ID
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId {get;set;}
        /// <summary>
        ///  用户名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  用户手机号
        /// </summary>
        [JsonProperty("phone")]
        public string  Phone {get;set;}
        /// <summary>
        ///  用户邮箱
        /// </summary>
        [JsonProperty("email")]
        public string  Email {get;set;}
        /// <summary>
        ///  授权 API
        /// </summary>
        [JsonProperty("apiAuthorized")]
        public bool  ApiAuthorized {get;set;}
        /// <summary>
        ///  最后登录时间
        /// </summary>
        [JsonProperty("lastLogin")]
        public string  LastLogin {get;set;}
    }
}