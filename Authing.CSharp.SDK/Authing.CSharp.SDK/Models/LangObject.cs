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
    /// LangObject 的模型
    /// </summary>
    public partial class LangObject
    {
        /// <summary>
        ///  多语言的中文内容
        /// </summary>
        [JsonProperty("zh-CN")]
        public LangUnit  ZhCN  {get;set;}
        /// <summary>
        ///  多语言的英文内容
        /// </summary>
        [JsonProperty("en-US")]
        public LangUnit  EnUS  {get;set;}
        /// <summary>
        ///  多语言的繁体中文内容
        /// </summary>
        [JsonProperty("zh-TW")]
        public LangUnit  ZhTW  {get;set;}
        /// <summary>
        ///  多语言的日语内容
        /// </summary>
        [JsonProperty("ja-JP")]
        public LangUnit  JaJP  {get;set;}
    }
}