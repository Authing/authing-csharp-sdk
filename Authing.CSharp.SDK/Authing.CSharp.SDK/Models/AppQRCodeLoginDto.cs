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
    /// AppQRCodeLoginDto 的模型
    /// </summary>
    public partial class AppQRCodeLoginDto
    {
        /// <summary>
        ///  APP 扫二维码登录:
/// - `APP_LOGIN`: APP 扫码登录；
/// 
        /// </summary>
        [JsonProperty("action")]
        public action  Action  {get;set;}
        /// <summary>
        ///  二维码唯一 ID
        /// </summary>
        [JsonProperty("qrcodeId")]
        public string  QrcodeId  {get;set;}
    }
    public partial class AppQRCodeLoginDto
    {
        /// <summary>
        ///  APP 扫二维码登录:
/// - `APP_LOGIN`: APP 扫码登录；
/// 
        /// </summary>
        public enum action
        {
            [EnumMember(Value="APP_LOGIN")]
            APP_LOGIN,
        }
    }
}