using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models.Authentication
{
    /// <summary>
    /// 获取小程序的手机号参数类
    /// </summary>
    public class GetWechatMiniprogramPhoneDto
    {
        /// <summary>
        /// 微信小程序的外部身份源连接标志符
        /// </summary>
        [JsonProperty("extIdpConnidentifier")]
        public string extIdpConnidentifier { get; set; }

        /// <summary>
        /// open-type=getphonecode 接口返回的 code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
