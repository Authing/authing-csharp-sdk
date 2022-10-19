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
/// SignUpProfileDto 的模型
/// </summary>
public partial class SignUpProfileDto
{
    /// <summary>
    ///  昵称
    /// </summary>
    [JsonProperty("nickname")]
    public string  Nickname {get;set;}
    /// <summary>
    ///  公司
    /// </summary>
    [JsonProperty("company")]
    public string  Company {get;set;}
    /// <summary>
    ///  头像
    /// </summary>
    [JsonProperty("photo")]
    public string  Photo {get;set;}
    /// <summary>
    ///  设备
    /// </summary>
    [JsonProperty("device")]
    public string  Device {get;set;}
    /// <summary>
    ///  浏览器
    /// </summary>
    [JsonProperty("browser")]
    public string  Browser {get;set;}
    /// <summary>
    ///  名称
    /// </summary>
    [JsonProperty("name")]
    public string  Name {get;set;}
    /// <summary>
    ///  名
    /// </summary>
    [JsonProperty("givenName")]
    public string  GivenName {get;set;}
    /// <summary>
    ///  姓
    /// </summary>
    [JsonProperty("familyName")]
    public string  FamilyName {get;set;}
    /// <summary>
    ///  中间名
    /// </summary>
    [JsonProperty("middleName")]
    public string  MiddleName {get;set;}
    /// <summary>
    ///  资料
    /// </summary>
    [JsonProperty("profile")]
    public string  Profile {get;set;}
    /// <summary>
    ///  希望称呼的用户名
    /// </summary>
    [JsonProperty("preferredUsername")]
    public string  PreferredUsername {get;set;}
    /// <summary>
    ///  网站
    /// </summary>
    [JsonProperty("website")]
    public string  Website {get;set;}
    /// <summary>
    ///  性别 W : 女性; M : 男性
    /// </summary>
    [JsonProperty("gender")]
    public gender  Gender {get;set;}
    /// <summary>
    ///  生日
    /// </summary>
    [JsonProperty("birthdate")]
    public string  Birthdate {get;set;}
    /// <summary>
    ///  地区
    /// </summary>
    [JsonProperty("zoneinfo")]
    public string  Zoneinfo {get;set;}
    /// <summary>
    ///  语言地区
    /// </summary>
    [JsonProperty("locale")]
    public string  Locale {get;set;}
    /// <summary>
    ///  地址
    /// </summary>
    [JsonProperty("address")]
    public string  Address {get;set;}
    /// <summary>
    ///  格式
    /// </summary>
    [JsonProperty("formatted")]
    public string  Formatted {get;set;}
    /// <summary>
    ///  街道地址
    /// </summary>
    [JsonProperty("streetAddress")]
    public string  StreetAddress {get;set;}
    /// <summary>
    ///  位置
    /// </summary>
    [JsonProperty("locality")]
    public string  Locality {get;set;}
    /// <summary>
    ///  地区
    /// </summary>
    [JsonProperty("region")]
    public string  Region {get;set;}
    /// <summary>
    ///  邮政编码
    /// </summary>
    [JsonProperty("postalCode")]
    public string  PostalCode {get;set;}
    /// <summary>
    ///  国家
    /// </summary>
    [JsonProperty("country")]
    public string  Country {get;set;}
    /// <summary>
    ///  邮箱
    /// </summary>
    [JsonProperty("email")]
    public string  Email {get;set;}
    /// <summary>
    ///  手机号
    /// </summary>
    [JsonProperty("phone")]
    public string  Phone {get;set;}
    /// <summary>
    ///  用户自定义字段
    /// </summary>
    [JsonProperty("customData")]
    public object  CustomData {get;set;}
}
public partial class SignUpProfileDto
 {
    /// <summary>
    ///  性别 W : 女性; M : 男性
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