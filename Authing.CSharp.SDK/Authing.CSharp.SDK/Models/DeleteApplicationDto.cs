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
/// DeleteApplicationDto 的模型
/// </summary>
public partial class DeleteApplicationDto
{
    /// <summary>
    ///  应用 ID
    /// </summary>
    [JsonProperty("appId")]
    public string  AppId {get;set;}
}
}