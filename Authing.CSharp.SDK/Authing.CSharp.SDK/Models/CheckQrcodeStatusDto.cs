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
/// CheckQrcodeStatusDto 的模型
/// </summary>
public partial class CheckQrcodeStatusDto
{
    /// <summary>
    ///  二维码唯一 ID
    /// </summary>
    [JsonProperty("qrcodeId")]
    public string  QrcodeId {get;set;} 
}
}