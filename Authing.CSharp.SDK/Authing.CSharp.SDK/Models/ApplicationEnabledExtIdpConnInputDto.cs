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
/// ApplicationEnabledExtIdpConnInputDto 的模型
/// </summary>
public partial class ApplicationEnabledExtIdpConnInputDto
{
    /// <summary>
    ///  身份源连接 ID
    /// </summary>
    [JsonProperty("extIdpConnId")]
    public string  ExtIdpConnId {get;set;}
}
}