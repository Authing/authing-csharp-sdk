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
    /// VerifyConfigDataDto 的模型
    /// </summary>
    public partial class VerifyConfigDataDto
    {
        /// <summary>
        ///  主键 ID
        /// </summary>
        [JsonProperty("id")]
        public string  Id {get;set;}
        /// <summary>
        ///  应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public string  AppId {get;set;}
        /// <summary>
        ///  是否开启接管 Windows 登录
        /// </summary>
        [JsonProperty("isWinLogin")]
        public bool  IsWinLogin {get;set;}
        /// <summary>
        ///  是否开启接管 Windows 更改密码
        /// </summary>
        [JsonProperty("isWinChangePwd")]
        public bool  IsWinChangePwd {get;set;}
        /// <summary>
        ///  密钥
        /// </summary>
        [JsonProperty("appSecret")]
        public string  AppSecret {get;set;}
        /// <summary>
        ///  固定值，public-key
        /// </summary>
        [JsonProperty("publicKey")]
        public string  PublicKey {get;set;}
        /// <summary>
        ///  公钥地址
        /// </summary>
        [JsonProperty("authAddress")]
        public string  AuthAddress {get;set;}
        /// <summary>
        ///  应用图片
        /// </summary>
        [JsonProperty("logo")]
        public string  Logo {get;set;}
        /// <summary>
        ///  应用图片
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
    }
}