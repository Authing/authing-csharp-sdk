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
    /// LinkIdentityDto 的模型
    /// </summary>
    public partial class LinkIdentityDto
    {
        /// <summary>
        ///  必传，用户在该外部身份源的唯一标识，需要从外部身份源的认证返回值中获取。
        /// </summary>
        [JsonProperty("userIdInIdp")]
        public string  UserIdInIdp {get;set;}
        /// <summary>
        ///  必传，进行绑定操作的 Authing 用户 ID。
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId {get;set;}
        /// <summary>
        ///  必传，身份源 ID，用于指定该身份属于哪个身份源。
        /// </summary>
        [JsonProperty("extIdpId")]
        public string  ExtIdpId {get;set;}
        /// <summary>
        ///  非必传，表示该条身份的具体类型，可从用户身份信息的 type 字段中获取。如果不传，默认为 generic
        /// </summary>
        [JsonProperty("type")]
        public string  Type {get;set;}
        /// <summary>
        ///  已废弃，可任意传入，未来将移除该字段。
        /// </summary>
        [JsonProperty("isSocial")]
        public bool  IsSocial {get;set;}
    }
}