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
    /// CreateTerminalDto 的模型
    /// </summary>
    public partial class CreateTerminalDto
    {
        /// <summary>
        ///  设备唯一标识
        /// </summary>
        [JsonProperty("deviceUniqueId")]
        public string  DeviceUniqueId {get;set;}
        /// <summary>
        ///  设备类型
        /// </summary>
        [JsonProperty("type")]
        public type  Type {get;set;}
        /// <summary>
        ///  自定义数据, 自定义数据的属性对应在元数据里自定义的字段
        /// </summary>
        [JsonProperty("customData")]
        public object  CustomData {get;set;}
        /// <summary>
        ///  设备名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  系统版本
        /// </summary>
        [JsonProperty("version")]
        public string  Version {get;set;}
        /// <summary>
        ///  硬件存储秘钥
        /// </summary>
        [JsonProperty("hks")]
        public string  Hks {get;set;}
        /// <summary>
        ///  磁盘加密
        /// </summary>
        [JsonProperty("fde")]
        public string  Fde {get;set;}
        /// <summary>
        ///  硬件越狱
        /// </summary>
        [JsonProperty("hor")]
        public bool  Hor {get;set;}
        /// <summary>
        ///  设备序列号
        /// </summary>
        [JsonProperty("sn")]
        public string  Sn {get;set;}
        /// <summary>
        ///  制造商
        /// </summary>
        [JsonProperty("producer")]
        public string  Producer {get;set;}
        /// <summary>
        ///  设备模组
        /// </summary>
        [JsonProperty("mod")]
        public string  Mod {get;set;}
        /// <summary>
        ///  设备系统
        /// </summary>
        [JsonProperty("os")]
        public string  Os {get;set;}
        /// <summary>
        ///  国际识别码
        /// </summary>
        [JsonProperty("imei")]
        public string  Imei {get;set;}
        /// <summary>
        ///  设备识别码
        /// </summary>
        [JsonProperty("meid")]
        public string  Meid {get;set;}
        /// <summary>
        ///  设备描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description {get;set;}
        /// <summary>
        ///  设备语言
        /// </summary>
        [JsonProperty("language")]
        public string  Language {get;set;}
        /// <summary>
        ///  是否开启 Cookies
        /// </summary>
        [JsonProperty("cookie")]
        public bool  Cookie {get;set;}
        /// <summary>
        ///  用户代理
        /// </summary>
        [JsonProperty("userAgent")]
        public string  UserAgent {get;set;}
    }
    public partial class CreateTerminalDto
    {
        /// <summary>
        ///  设备类型
        /// </summary>
        public enum type
        {
            [EnumMember(Value="Browser")]
            BROWSER,
            [EnumMember(Value="Mobile")]
            MOBILE,
            [EnumMember(Value="Desktop")]
            DESKTOP,
        }
    }
}