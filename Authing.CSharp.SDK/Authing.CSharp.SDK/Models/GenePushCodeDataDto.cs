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
    /// GenePushCodeDataDto 的模型
    /// </summary>
    public partial class GenePushCodeDataDto
    {
        /// <summary>
        ///  推送码（推送登录唯一 ID），可以通过此唯一 ID 查询推送码状态。
        /// </summary>
        [JsonProperty("pushCodeId")]
        public string  PushCodeId  {get;set;}
        /// <summary>
        ///  推送码 `${expireTime}` 秒后过期，如 120 秒后过期。
        /// </summary>
        [JsonProperty("expireTime")]
        public long  ExpireTime  {get;set;}
    }
}