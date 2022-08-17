using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Authing.CSharp.SDK.Models.Authentication
{
    /// <summary>
    /// 解密微信小程序数据请求参数类
    /// </summary>
    public class DecryptWechatMiniProgramDataDto
    {
        /// <summary>
        /// 获取微信开放数据返回的加密数据（encryptedData）
        /// </summary>
        [JsonProperty("encryptedData")]
        public string EncryptedData { get; set; }

        /// <summary>
        /// 对称解密算法初始向量，由微信返回
        /// </summary>
        [JsonProperty("iv")]
        public string Iv { get; set; }

        /// <summary>
        /// wx.login 接口返回的用户 code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
