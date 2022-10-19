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
/// SMTPEmailProviderConfig 的模型
/// </summary>
public partial class SMTPEmailProviderConfig
{
    /// <summary>
    ///  SMTP 地址
    /// </summary>
    [JsonProperty("smtpHost")]
    public string  SmtpHost {get;set;}
    /// <summary>
    ///  SMTP 端口
    /// </summary>
    [JsonProperty("smtpPort")]
    public long  SmtpPort {get;set;}
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
    [JsonProperty("enableSSL")]
    public bool  EnableSSL {get;set;}
}
}