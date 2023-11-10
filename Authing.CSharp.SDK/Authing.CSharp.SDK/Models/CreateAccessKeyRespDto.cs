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
    /// CreateAccessKeyRespDto 的模型
    /// </summary>
    public partial class CreateAccessKeyRespDto
    {
        /// <summary>
        ///  用户所拥有的 accessKeyId
        /// </summary>
        [JsonProperty("accessKeyId")]
        public string  AccessKeyId {get;set;}
        /// <summary>
        ///  用户所拥有的 accessKeySecret
        /// </summary>
        [JsonProperty("accessKeySecret")]
        public string  AccessKeySecret {get;set;}
        /// <summary>
        ///  用户 ID
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId {get;set;}
        /// <summary>
        ///  创建时间
        /// </summary>
        [JsonProperty("createdAt")]
        public string  CreatedAt {get;set;}
        /// <summary>
        ///  accessKeyId 状态
        /// </summary>
        [JsonProperty("status")]
        public string  Status {get;set;}
        /// <summary>
        ///  最后使用时间
        /// </summary>
        [JsonProperty("lastDate")]
        public string  LastDate {get;set;}
        /// <summary>
        ///  accessKeyId 所在用户池
        /// </summary>
        [JsonProperty("userPoolId")]
        public string  UserPoolId {get;set;}
        /// <summary>
        ///  密钥是否启用
        /// </summary>
        [JsonProperty("enable")]
        public bool  Enable {get;set;}
    }
}