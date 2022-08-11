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
    /// GetUserAuthorizedAppsDto 的模型
    /// </summary>
    public partial class GetUserAuthorizedAppsDto
    {
        /// <summary>
        ///  用户 ID
        /// </summary>
        [JsonProperty("userId")]
        public object UserId { get; set; }
        /// <summary>
        ///  用户 ID 类型，可以指定为用户 ID、手机号、邮箱、用户名和 externalId。
        /// </summary>
        [JsonProperty("userIdType")]
        public object UserIdType { get; set; }
    }
}