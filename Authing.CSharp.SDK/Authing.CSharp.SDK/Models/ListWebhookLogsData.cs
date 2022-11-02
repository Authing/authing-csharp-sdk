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
/// ListWebhookLogsData 的模型
/// </summary>
public partial class ListWebhookLogsData
{
    /// <summary>
    ///  记录总数
    /// </summary>
    [JsonProperty("totalCount")]
    public long  TotalCount {get;set;}
    /// <summary>
    ///  返回列表
    /// </summary>
    [JsonProperty("list")]
    public List<WebhookLogDto>  List {get;set;}
}
}