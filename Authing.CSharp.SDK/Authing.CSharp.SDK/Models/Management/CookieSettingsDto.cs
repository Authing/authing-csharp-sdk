using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models.Management;

namespace Authing.CSharp.SDK.Models.Management
{
    /// <summary>
    /// CookieSettingsDto 的模型
    /// </summary>
    public partial class CookieSettingsDto
    {
        /// <summary>
        ///  Cookie 有效时间：用户登录状态的有效时间（默认为 1209600 秒/ 14 天），过期后用户需要重新登录。对于应用面板及已加入应用面板的应用，将使用此 cookie  过期时间。
        /// </summary>
        [JsonProperty("cookieExpiresIn")]
        public long CookieExpiresIn { get; set; }
        /// <summary>
        ///  Cookie 过期时间基于浏览器会话：当前浏览器关闭后立即过期，下次打开需重新登录。
        /// </summary>
        [JsonProperty("cookieExpiresOnBrowserSession")]
        public bool CookieExpiresOnBrowserSession { get; set; }
    }
}