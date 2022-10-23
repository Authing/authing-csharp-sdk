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
/// UnlinkExtIdpDto 的模型
/// </summary>
public partial class UnlinkExtIdpDto
{
    /// <summary>
    ///  外部身份源 ID
    /// </summary>
    [JsonProperty("extIdpId")]
    public string  ExtIdpId {get;set;}
}
}