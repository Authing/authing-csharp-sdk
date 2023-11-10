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
    /// SetPublicAccountBatchReqDto 的模型
    /// </summary>
    public partial class SetPublicAccountBatchReqDto
    {
        /// <summary>
        ///  用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。
        /// </summary>
        [JsonProperty("publicAccountId")]
        public string  PublicAccountId {get;set;}
        /// <summary>
        ///  用户 ID 数组
        /// </summary>
        [JsonProperty("userIds")]
        public List<string>  UserIds {get;set;}
    }
}