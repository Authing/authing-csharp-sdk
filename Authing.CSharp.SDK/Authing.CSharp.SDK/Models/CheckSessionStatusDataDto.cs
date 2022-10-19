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
/// CheckSessionStatusDataDto 的模型
/// </summary>
public partial class CheckSessionStatusDataDto
{
    /// <summary>
    ///  是否具有登录态
    /// </summary>
    [JsonProperty("active")]
    public bool  Active {get;set;}
}
}