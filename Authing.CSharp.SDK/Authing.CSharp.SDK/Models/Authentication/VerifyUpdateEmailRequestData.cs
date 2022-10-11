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
    /// VerifyUpdateEmailRequestData 的模型
    /// </summary>
    public partial class VerifyUpdateEmailRequestData
    {
        /// <summary>
        ///  用于修改当前邮箱的 token，你需要使用此 token 调用**修改邮箱**接口。
        /// </summary>
        [JsonProperty("updateEmailToken")]
        public    string   UpdateEmailToken    {get;set;}
        /// <summary>
        ///  Token 有效时间，时间为 60 秒。
        /// </summary>
        [JsonProperty("tokenExpiresIn")]
        public    long   TokenExpiresIn    {get;set;}
    }
}