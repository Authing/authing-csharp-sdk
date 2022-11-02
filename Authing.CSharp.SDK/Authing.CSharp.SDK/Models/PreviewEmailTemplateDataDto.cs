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
/// PreviewEmailTemplateDataDto 的模型
/// </summary>
public partial class PreviewEmailTemplateDataDto
{
    /// <summary>
    ///  预览的邮件主体内容，为 html 格式文本
    /// </summary>
    [JsonProperty("content")]
    public string  Content {get;set;}
    /// <summary>
    ///  预览的邮件主题内容
    /// </summary>
    [JsonProperty("subject")]
    public string  Subject {get;set;}
    /// <summary>
    ///  预览的邮件发件人内容
    /// </summary>
    [JsonProperty("sender")]
    public string  Sender {get;set;}
}
}