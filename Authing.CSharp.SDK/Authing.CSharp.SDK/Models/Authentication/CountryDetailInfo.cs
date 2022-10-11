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
    /// CountryDetailInfo 的模型
    /// </summary>
    public partial class CountryDetailInfo
    {
        /// <summary>
        ///  [ISO 3166 国际标准](https://www.iban.com/country-codes)中国家的 Alpha-2 简称
        /// </summary>
        [JsonProperty("alpha2")]
        public    string   Alpha2    {get;set;}
        /// <summary>
        ///  [ISO 3166 国际标准](https://www.iban.com/country-codes)中国家的 Alpha-3 简称
        /// </summary>
        [JsonProperty("alpha3")]
        public    string   Alpha3    {get;set;}
        /// <summary>
        ///  国家手机区号
        /// </summary>
        [JsonProperty("phoneCountryCode")]
        public    string   PhoneCountryCode    {get;set;}
        /// <summary>
        ///  国旗图标
        /// </summary>
        [JsonProperty("flag")]
        public    string   Flag    {get;set;}
        /// <summary>
        ///  名称，多语言结构，目前只支持中文和英文
        /// </summary>
        [JsonProperty("name")]
        public    LangObject   Name    {get;set;}
    }
}