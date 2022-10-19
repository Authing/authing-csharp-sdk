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
/// DeleteExtIdpConnDto 的模型
/// </summary>
public partial class DeleteExtIdpConnDto
{
    /// <summary>
    ///  身份源连接 ID
    /// </summary>
    [JsonProperty("id")]
    public string  Id {get;set;}
}
}