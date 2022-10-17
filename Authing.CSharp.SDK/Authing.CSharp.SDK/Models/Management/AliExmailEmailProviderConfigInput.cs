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
/// AliExmailEmailProviderConfigInput 的模型
/// </summary>
public partial class AliExmailEmailProviderConfigInput
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