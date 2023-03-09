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
    /// GeneQRCodeDataDto 的模型
    /// </summary>
    public partial class GeneQRCodeDataDto
    {
        /// <summary>
        ///  二维码唯一 ID，可以通过此唯一 ID 查询二维码状态。
        /// </summary>
        [JsonProperty("qrcodeId")]
        public string  QrcodeId  {get;set;}
        /// <summary>
        ///  二维码 URL，前端可以基于此链接渲染二维码。
        /// </summary>
        [JsonProperty("url")]
        public string  Url  {get;set;}
        /// <summary>
        ///  如果是小程序扫码登录，并且请求参数 autoMergeQrCode 设置为 false，会返回配置的自定义 Logo，前端可以自行将此 Logo 拼接到二维码 URL 上。
        /// </summary>
        [JsonProperty("customLogoUrl")]
        public string  CustomLogoUrl  {get;set;}
    }
}