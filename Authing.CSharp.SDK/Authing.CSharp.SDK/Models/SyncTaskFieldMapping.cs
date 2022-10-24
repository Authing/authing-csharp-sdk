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
/// SyncTaskFieldMapping 的模型
/// </summary>
public partial class SyncTaskFieldMapping
{
    /// <summary>
    ///  源字段
    /// </summary>
    [JsonProperty("expression")]
    public string  Expression {get;set;}
    /// <summary>
    ///  转换后的字段
    /// </summary>
    [JsonProperty("targetKey")]
    public string  TargetKey {get;set;}
}
}