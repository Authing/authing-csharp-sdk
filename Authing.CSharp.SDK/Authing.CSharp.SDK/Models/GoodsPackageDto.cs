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
/// GoodsPackageDto 的模型
/// </summary>
public partial class GoodsPackageDto
{
    /// <summary>
    ///  套餐包名称 name
    /// </summary>
    [JsonProperty("name")]
    public string  Name {get;set;}
    /// <summary>
    ///  套餐包名称 nameEn
    /// </summary>
    [JsonProperty("nameEn")]
    public string  NameEn {get;set;}
    /// <summary>
    ///  套餐包单价
    /// </summary>
    [JsonProperty("unitPrice")]
    public string  UnitPrice {get;set;}
    /// <summary>
    ///  套餐包编码 code
    /// </summary>
    [JsonProperty("code")]
    public string  Code {get;set;}
    /// <summary>
    ///  套餐包版本
    /// </summary>
    [JsonProperty("group")]
    public string  Group {get;set;}
    /// <summary>
    ///  套餐包场景编码
    /// </summary>
    [JsonProperty("sceneCode")]
    public string  SceneCode {get;set;}
    /// <summary>
    ///  套餐包 MAU 数量
    /// </summary>
    [JsonProperty("amount")]
    public string  Amount {get;set;}
}
}