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
/// UpdateUserProfileDto 的模型
/// </summary>
public partial class UpdateUserProfileDto
{
    /// <summary>
    ///  用户真实名称，不具备唯一性
    /// </summary>
    [JsonProperty("name")]
    public string  Name {get;set;}
    /// <summary>
    ///  昵称
    /// </summary>
    [JsonProperty("nickname")]
    public string  Nickname {get;set;}
    /// <summary>
    ///  头像链接
    /// </summary>
    [JsonProperty("photo")]
    public string  Photo {get;set;}
    /// <summary>
    ///  第三方外部 ID
    /// </summary>
    [JsonProperty("externalId")]
    public string  ExternalId {get;set;}
    /// <summary>
    ///  出生日期
    /// </summary>
    [JsonProperty("birthdate")]
    public string  Birthdate {get;set;}
    /// <summary>
    ///  所在国家
    /// </summary>
    [JsonProperty("country")]
    public string  Country {get;set;}
    /// <summary>
    ///  所在省份
    /// </summary>
    [JsonProperty("province")]
    public string  Province {get;set;}
    /// <summary>
    ///  所在城市
    /// </summary>
    [JsonProperty("city")]
    public string  City {get;set;}
    /// <summary>
    ///  所处地址
    /// </summary>
    [JsonProperty("address")]
    public string  Address {get;set;}
    /// <summary>
    ///  所处街道地址
    /// </summary>
    [JsonProperty("streetAddress")]
    public string  StreetAddress {get;set;}
    /// <summary>
    ///  邮政编码号
    /// </summary>
    [JsonProperty("postalCode")]
    public string  PostalCode {get;set;}
    /// <summary>
    ///  性别
    /// </summary>
    [JsonProperty("gender")]
    public gender  Gender {get;set;}
    /// <summary>
    ///  用户名，用户池内唯一
    /// </summary>
    [JsonProperty("username")]
    public string  Username {get;set;}
    /// <summary>
    ///  自定义数据，传入的对象中的 key 必须先在用户池定义相关自定义字段
    /// </summary>
    [JsonProperty("customData")]
    public object  CustomData {get;set;}
}
public partial class UpdateUserProfileDto
 {
    /// <summary>
    ///  性别
    /// </summary>
    public enum gender
     {
         [EnumMember(Value="M")]
        M,
         [EnumMember(Value="F")]
        F,
         [EnumMember(Value="U")]
        U,
    }
}
}