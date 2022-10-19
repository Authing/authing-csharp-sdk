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
/// GeoIp 的模型
/// </summary>
public partial class GeoIp
{
    /// <summary>
    ///  地理位置
    /// </summary>
    [JsonProperty("location")]
    public GeoIpLocation  Location {get;set;}
    /// <summary>
    ///  Country Name
    /// </summary>
    [JsonProperty("country_name")]
    public string  Country_name {get;set;}
    /// <summary>
    ///  Country Code 2
    /// </summary>
    [JsonProperty("country_code2")]
    public string  Country_code2 {get;set;}
    /// <summary>
    ///  Country Code 3
    /// </summary>
    [JsonProperty("country_code3")]
    public string  Country_code3 {get;set;}
    /// <summary>
    ///  Region Name
    /// </summary>
    [JsonProperty("region_name")]
    public string  Region_name {get;set;}
    /// <summary>
    ///  Region Code
    /// </summary>
    [JsonProperty("region_code")]
    public string  Region_code {get;set;}
    /// <summary>
    ///  城市名称
    /// </summary>
    [JsonProperty("city_name")]
    public string  City_name {get;set;}
    /// <summary>
    ///  Continent Code
    /// </summary>
    [JsonProperty("continent_code")]
    public string  Continent_code {get;set;}
    /// <summary>
    ///  时区
    /// </summary>
    [JsonProperty("timezone")]
    public string  Timezone {get;set;}
}
}