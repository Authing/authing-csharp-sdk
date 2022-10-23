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
/// SMTPEmailProviderConfigInput 的模型
/// </summary>
public partial class SMTPEmailProviderConfigInput
{
    /// <summary>
    ///  SMTP 地址
    /// </summary>
    [JsonProperty("smtp_host")]
    public string  Smtp_host {get;set;}
    /// <summary>
    ///  SMTP 端口
    /// </summary>
    [JsonProperty("smtp_port")]
    public long  Smtp_port {get;set;}
    /// <summary>
    ///  用户名
    /// </summary>
    [JsonProperty("sender")]
    public string  Sender {get;set;}
    /// <summary>
    ///  密码
    /// </summary>
    [JsonProperty("senderPass")]
    public string  SenderPass {get;set;}
    /// <summary>
    ///  是否启用 SSL
    /// </summary>
    [JsonProperty("secure")]
    public bool  Secure {get;set;}
}
}