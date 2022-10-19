using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models.Management;

   namespace Authing.CSharp.SDK.Models.Management
{
/// <summary>
/// CostCurrentPackageInfo 的模型
/// </summary>
public partial class CostCurrentPackageInfo
{
    /// <summary>
    ///  套餐包编码
    /// </summary>
    [JsonProperty("code")]
    public string  Code {get;set;}
    /// <summary>
    ///  套餐结束时间
    /// </summary>
    [JsonProperty("endTime")]
    public string  EndTime {get;set;}
    /// <summary>
    ///  套餐逾期天数
    /// </summary>
    [JsonProperty("overdueDays")]
    public string  OverdueDays {get;set;}
    /// <summary>
    ///  套餐包信息
    /// </summary>
    [JsonProperty("goodsPackage")]
    public GoodsPackageDto  GoodsPackage {get;set;}
}
}