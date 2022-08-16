using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class GeneQRCodeRespDto
    {
        /// <summary>
        /// 业务状态码，可以通过此状态码判断操作是否成功，200 表示成功
        /// </summary>
        [JsonProperty("statusCode")]
        public long StatusCode { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 细分错误码，可通过此错误码得到具体的错误类型
        /// </summary>
        [JsonProperty("apicode")]
        public long ApiCode { get; set; }

        [JsonProperty("data")]
        public GeneQRCodeResp Data { get; set; }
    }

    public class GeneQRCodeResp
    {
        /// <summary>
        /// 二维码唯一 ID，可以通过此唯一 ID 查询二维码状态。
        /// </summary>
        public string QrcodeId { get; set; }
        /// <summary>
        /// 二维码 URL，前端可以基于此链接渲染二维码。
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 如果是小程序扫码登录，并且请求参数 autoMergeQrCode 设置为 false，会返回配置的自定义 Logo，前端可以自行将此 Logo 拼接到二维码 URL 上。
        /// </summary>
        public string CustomLogoUrl { get; set; }
    }
}
