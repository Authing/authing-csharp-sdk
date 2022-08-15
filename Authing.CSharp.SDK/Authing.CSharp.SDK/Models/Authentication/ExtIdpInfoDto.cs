using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Authing.CSharp.SDK.Models.Authentication
{
    /// <summary>
    /// mark
    /// </summary>
    public class GetExtIdpsRespDto
    {
        /// <summary>
        /// 业务状态码，可以通过此状态码判断操作是否成功，200 表示成功
        /// </summary>
        [JsonProperty("statusCode")]
        public string statusCode { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 细分错误码，可通过此错误码得到具体的错误类型
        /// </summary>
        [JsonProperty("apiCode")]
        public string ApiCode { get; set; }

        /// <summary>
        ///  外部身份源列表
        /// </summary>
        [JsonProperty("data")]
        public IEnumerable<ExtIdpInfoDto> Data { get; set; }
    }

    /// <summary>
    /// 外部身份源
    /// </summary>
    public class ExtIdpInfoDto
    {
        /// <summary>
        /// 身份源连接唯一标志
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// 身份源 ID
        /// </summary>
        [JsonProperty("extIdpId")]
        public string ExtIdpId { get; set; }

        /// <summary>
        /// 身份源类型
        /// </summary>
        [JsonProperty("type")]
        public Type Type { get; set; }

        /// <summary>
        /// 认证类型
        /// </summary>
        [JsonProperty("extIdpType")]
        public ExtIdpType ExtIdpType { get; set; }

        /// <summary>
        /// 认证地址
        /// </summary>
        [JsonProperty("bindUrl")]
        public string BindUrl { get; set; }

        /// <summary>
        /// 身份源显示名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 身份源显示名称(英文)
        /// </summary>
        [JsonProperty("name_en")]
        public string NameEn { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 描述英文
        /// </summary>
        [JsonProperty("desc_en")]
        public string DescEn { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

    }
}
