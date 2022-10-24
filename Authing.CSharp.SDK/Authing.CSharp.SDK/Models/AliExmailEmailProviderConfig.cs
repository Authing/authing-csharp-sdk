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
/// AliExmailEmailProviderConfig 的模型
/// </summary>
public partial class AliExmailEmailProviderConfig
{
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
}
}