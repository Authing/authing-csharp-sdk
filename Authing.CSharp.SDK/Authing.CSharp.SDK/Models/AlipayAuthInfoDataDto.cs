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
/// AlipayAuthInfoDataDto 的模型
/// </summary>
public partial class AlipayAuthInfoDataDto
{
    /// <summary>
    ///  拉起支付宝需要的 AuthInfo
    /// </summary>
    [JsonProperty("authInfo")]
    public string  AuthInfo {get;set;}
}
}