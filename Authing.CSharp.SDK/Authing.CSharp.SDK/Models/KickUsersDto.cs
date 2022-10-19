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
/// KickUsersDto 的模型
/// </summary>
public partial class KickUsersDto
{
    /// <summary>
    ///  APP ID 列表
    /// </summary>
    [JsonProperty("appIds")]
    public List<string>  AppIds {get;set;}
    /// <summary>
    ///  用户 ID
    /// </summary>
    [JsonProperty("userId")]
    public string  UserId {get;set;}
    /// <summary>
    ///  可选参数
    /// </summary>
    [JsonProperty("options")]
    public KickUsersOptionsDto  Options {get;set;}
}
}