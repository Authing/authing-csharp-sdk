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
    /// UserListCreateDto 的模型
    /// </summary>
    public partial class UserListCreateDto
    {
        /// <summary>
        ///  过期时间
        /// </summary>
        [JsonProperty("expireAt")]
        public long  ExpireAt {get;set;}
        /// <summary>
        ///  限制类型，FORBID_LOGIN-禁止登录，FORBID_REGISTER-禁止注册，SKIP_MFA-跳过 MFA
        /// </summary>
        [JsonProperty("limitList")]
        public List<string>  LimitList {get;set;}
        /// <summary>
        ///  删除类型，MANUAL-手动，SCHEDULE-策略删除
        /// </summary>
        [JsonProperty("removeType")]
        public string  RemoveType {get;set;}
        /// <summary>
        ///  添加类型，MANUAL-手动，SCHEDULE-策略添加
        /// </summary>
        [JsonProperty("addType")]
        public string  AddType {get;set;}
        /// <summary>
        ///  用户名单类型，WHITE-白名单，BLACK-黑名单
        /// </summary>
        [JsonProperty("userListType")]
        public string  UserListType {get;set;}
        /// <summary>
        ///  userId, 多个 userId 以逗号分割
        /// </summary>
        [JsonProperty("userIds")]
        public List<string>  UserIds {get;set;}
    }
}