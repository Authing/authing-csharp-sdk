using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class SignInByFacebookPayloadDto
    {
        /// <summary>
        ///  Facebook 移动端社会化登录获取到的 code
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
}
