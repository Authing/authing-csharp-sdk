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
/// LangUnit 的模型
/// </summary>
public partial class LangUnit
{
    /// <summary>
    ///  是否已开启。若开启，且控制台选择该语言，则展示该内容。（默认关闭）
    /// </summary>
    [JsonProperty("enabled")]
    public bool  Enabled {get;set;}
    /// <summary>
    ///  多语言内容
    /// </summary>
    [JsonProperty("value")]
    public string  Value {get;set;}
}
}