using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Authing.CSharp.SDK.Models.Authentication
{
    /// <summary>
    /// 绑定外部身份源参数类
    /// </summary>
    public class LinkExtIdpParams
    {
        /// <summary>
        /// 外部身份源连接唯一标志
        /// </summary>
        [JsonProperty("ext_idp_conn_identifier")]
        public string ExtIdpConnIdentifier { get; set; }

        /// <summary>
        /// Authing 应用 ID
        /// </summary>
        [JsonProperty("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// Authing 应用 ID
        /// </summary>
        [JsonProperty("id_token")] 
        public string IdToken { get; set; }
    }
}
