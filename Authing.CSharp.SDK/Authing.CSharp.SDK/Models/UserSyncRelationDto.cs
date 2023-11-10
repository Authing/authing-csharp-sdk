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
    /// UserSyncRelationDto 的模型
    /// </summary>
    public partial class UserSyncRelationDto
    {
        /// <summary>
        ///  外部身份源类型，如：
/// - `wechatwork`: 企业微信
/// - `dingtalk`: 钉钉
/// - `lark`: 飞书
/// - `welink`: Welink
/// - `ldap`: LDAP
/// - `active-directory`: Windows AD
/// - `italent`: 北森
/// - `xiaoshouyi`: 销售易
/// - `maycur`: 每刻报销
/// - `scim`: SCIM
/// - `moka`: Moka HR
/// 
        /// </summary>
        [JsonProperty("provider")]
        public string  Provider {get;set;}
        /// <summary>
        ///  在外部身份源中的 ID
        /// </summary>
        [JsonProperty("userIdInIdp")]
        public string  UserIdInIdp {get;set;}
        /// <summary>
        ///  用户在第三方中的身份信息
        /// </summary>
        [JsonProperty("userInfoInIdp")]
        public User  UserInfoInIdp {get;set;}
    }
}