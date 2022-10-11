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
/// EmailProviderDto 的模型
/// </summary>
public partial class EmailProviderDto
{
    /// <summary>
    ///  是否启用，如果不启用，将默认使用 Authing 内置的邮件服务
    /// </summary>
[JsonProperty("enabled")]
public    bool   Enabled    {get;set;}
    /// <summary>
    ///  第三方邮件服务商类型:
/// - `smtp`: 标准 SMTP 邮件服务
/// - `ali`: [阿里企业邮箱](https://www.ali-exmail.cn/Land/)
/// - `tencent`: [腾讯企业邮箱](https://work.weixin.qq.com/mail/)
/// - `sendgrid`: [SendGrid 邮件服务](https://sendgrid.com/)
/// 
    /// </summary>
[JsonProperty("type")]
public    type   Type    {get;set;}
    /// <summary>
    ///  SMTP 邮件服务配置
    /// </summary>
[JsonProperty("smtpConfig")]
public    SMTPEmailProviderConfig   SmtpConfig    {get;set;}
    /// <summary>
    ///  SendGrid 邮件服务配置
    /// </summary>
[JsonProperty("sendGridConfig")]
public    SendGridEmailProviderConfig   SendGridConfig    {get;set;}
    /// <summary>
    ///  阿里企业邮件服务配置
    /// </summary>
[JsonProperty("aliExmailConfig")]
public    AliExmailEmailProviderConfig   AliExmailConfig    {get;set;}
    /// <summary>
    ///  腾讯企业邮件服务配置
    /// </summary>
[JsonProperty("tencentExmailConfig")]
public    TencentExmailEmailProviderConfig   TencentExmailConfig    {get;set;}
}
public partial class EmailProviderDto
 {
    /// <summary>
    ///  第三方邮件服务商类型:
/// - `smtp`: 标准 SMTP 邮件服务
/// - `ali`: [阿里企业邮箱](https://www.ali-exmail.cn/Land/)
/// - `tencent`: [腾讯企业邮箱](https://work.weixin.qq.com/mail/)
/// - `sendgrid`: [SendGrid 邮件服务](https://sendgrid.com/)
/// 
    /// </summary>
    public enum type
     {
         [EnumMember(Value="smtp")]
        SMTP,
         [EnumMember(Value="ali")]
        ALI,
         [EnumMember(Value="tencent")]
        TENCENT,
         [EnumMember(Value="sendgrid")]
        SENDGRID,
    }
}
}