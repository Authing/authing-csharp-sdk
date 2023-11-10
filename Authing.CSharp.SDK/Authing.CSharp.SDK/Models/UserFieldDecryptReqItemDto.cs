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
    /// UserFieldDecryptReqItemDto 的模型
    /// </summary>
    public partial class UserFieldDecryptReqItemDto
    {
        /// <summary>
        ///  用户唯一标志，可以是用户 ID、用户名、邮箱、手机号、外部 ID、在外部身份源的 ID。
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId {get;set;}
        /// <summary>
        ///  字段的key名称，例如 username/phone
        /// </summary>
        [JsonProperty("fieldName")]
        public string  FieldName {get;set;}
        /// <summary>
        ///  字段加密后的内容
        /// </summary>
        [JsonProperty("encryptedContent")]
        public string  EncryptedContent {get;set;}
    }
}