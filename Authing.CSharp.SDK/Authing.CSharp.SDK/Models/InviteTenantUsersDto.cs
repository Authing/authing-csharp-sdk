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
    /// InviteTenantUsersDto 的模型
    /// </summary>
    public partial class InviteTenantUsersDto
    {
        /// <summary>
        ///  错误的邮箱提示
        /// </summary>
        [JsonProperty("errMsgs")]
        public List<errorEmailMsg>  ErrMsgs  {get;set;}
        /// <summary>
        ///  邀请用户信息返回值
        /// </summary>
        [JsonProperty("list")]
        public List<InviteTenantUserRecord>  List  {get;set;}
    }
}