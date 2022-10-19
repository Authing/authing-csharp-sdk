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
/// GetAlipayAuthinfoDto 的模型
/// </summary>
public partial class GetAlipayAuthinfoDto
{
    /// <summary>
    ///  外部身份源连接标志符
    /// </summary>
    [JsonProperty("extIdpConnidentifier")]
    public string  ExtIdpConnidentifier {get;set;} 
}
}