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
/// UnbindExtIdpDto 的模型
/// </summary>
public partial class UnbindExtIdpDto
{
    /// <summary>
    ///  外部身份源 ID
    /// </summary>
    [JsonProperty("extIdpId")]
    public string  ExtIdpId {get;set;}
}
}