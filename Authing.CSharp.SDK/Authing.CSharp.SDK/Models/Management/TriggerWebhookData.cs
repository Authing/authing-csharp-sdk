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
/// TriggerWebhookData 的模型
/// </summary>
public partial class TriggerWebhookData
{
    /// <summary>
    ///  原来接口返回的 response 数据
    /// </summary>
    [JsonProperty("response")]
    public Any  Response {get;set;}
}
}