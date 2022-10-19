using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models;

   namespace Authing.CSharp.SDK.Models
{
/// <summary>
/// DecryptWechatMiniProgramDataDto 的模型
/// </summary>
public partial class DecryptWechatMiniProgramDataDto
{
    /// <summary>
    ///  `wx.login` 接口返回的用户 `code`
    /// </summary>
    [JsonProperty("code")]
    public string  Code {get;set;}
    /// <summary>
    ///  对称解密算法初始向量，由微信返回
    /// </summary>
    [JsonProperty("iv")]
    public string  Iv {get;set;}
    /// <summary>
    ///  获取微信开放数据返回的加密数据（encryptedData）
    /// </summary>
    [JsonProperty("encryptedData")]
    public string  EncryptedData {get;set;}
    /// <summary>
    ///  微信小程序的外部身份源连接标志符
    /// </summary>
    [JsonProperty("extIdpConnidentifier")]
    public string  ExtIdpConnidentifier {get;set;}
}
}