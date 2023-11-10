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
    /// AuthEnvParams 的模型
    /// </summary>
    public partial class AuthEnvParams
    {
        /// <summary>
        ///  ip
        /// </summary>
        [JsonProperty("ip")]
        public string  Ip {get;set;}
        /// <summary>
        ///  城市
        /// </summary>
        [JsonProperty("city")]
        public string  City {get;set;}
        /// <summary>
        ///  省份
        /// </summary>
        [JsonProperty("province")]
        public string  Province {get;set;}
        /// <summary>
        ///  国家
        /// </summary>
        [JsonProperty("country")]
        public string  Country {get;set;}
        /// <summary>
        ///  设备类型：PC/Mobile
        /// </summary>
        [JsonProperty("deviceType")]
        public deviceType  DeviceType {get;set;}
        /// <summary>
        ///  操作类型：Windows、Android、iOS、MacOS
        /// </summary>
        [JsonProperty("systemType")]
        public systemType  SystemType {get;set;}
        /// <summary>
        ///  浏览器类型：IE/Chrome/Firefox
        /// </summary>
        [JsonProperty("browserType")]
        public browserType  BrowserType {get;set;}
        /// <summary>
        ///  请求时间
        /// </summary>
        [JsonProperty("requestDate")]
        public string  RequestDate {get;set;}
    }
    public partial class AuthEnvParams
    {
        /// <summary>
        ///  设备类型：PC/Mobile
        /// </summary>
        public enum deviceType
        {
            [EnumMember(Value="PC")]
            PC,
            [EnumMember(Value="Mobile")]
            MOBILE,
        }
        /// <summary>
        ///  操作类型：Windows、Android、iOS、MacOS
        /// </summary>
        public enum systemType
        {
            [EnumMember(Value="Windows")]
            WINDOWS,
            [EnumMember(Value="MacOS")]
            MAC_OS,
            [EnumMember(Value="Android")]
            ANDROID,
            [EnumMember(Value="iOS")]
            I_OS,
        }
        /// <summary>
        ///  浏览器类型：IE/Chrome/Firefox
        /// </summary>
        public enum browserType
        {
            [EnumMember(Value="IE")]
            IE,
            [EnumMember(Value="Chrome")]
            CHROME,
            [EnumMember(Value="Firefox")]
            FIREFOX,
            [EnumMember(Value="Safari")]
            SAFARI,
            [EnumMember(Value="Edge")]
            EDGE,
            [EnumMember(Value="Opera")]
            OPERA,
            [EnumMember(Value="Safe360")]
            SAFE360,
            [EnumMember(Value="QQBrowser")]
            QQBROWSER,
        }
    }
}