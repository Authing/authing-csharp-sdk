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
    /// IpListCreateDto 的模型
    /// </summary>
    public partial class IpListCreateDto
    {
        /// <summary>
        ///  添加时间
        /// </summary>
        [JsonProperty("expireAt")]
        public string  ExpireAt {get;set;}
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
        ///  ip类型，WHITE-白名单，BLACK-黑名单
        /// </summary>
        [JsonProperty("ipType")]
        public string  IpType {get;set;}
        /// <summary>
        ///  ip, 多个IP以逗号分割
        /// </summary>
        [JsonProperty("ips")]
        public string  Ips {get;set;}
    }
}