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
    /// ApplicationAgreementDto 的模型
    /// </summary>
    public partial class ApplicationAgreementDto
    {
        /// <summary>
        ///  展示的页面（可多选）：
/// - `LoginPage`: 登录页面
/// - `RegisterPage`: 注册页面
/// 
        /// </summary>
        [JsonProperty("displayAt")]
        public List<string>  DisplayAt  {get;set;}
        /// <summary>
        ///  是否要求必须勾选
        /// </summary>
        [JsonProperty("isRequired")]
        public bool  IsRequired  {get;set;}
        /// <summary>
        ///  此协议针对什么语言有效:
/// - `zh-CN`: 简体中文
/// - `zh-TW`: 繁体中文
/// - `en-US`: 英文
/// - `ja-JP`: 日语
/// 
        /// </summary>
        [JsonProperty("lang")]
        public lang  Lang  {get;set;}
        /// <summary>
        ///  此协议针对什么语言有效
        /// </summary>
        [JsonProperty("content")]
        public string  Content  {get;set;}
    }
    public partial class ApplicationAgreementDto
    {
        /// <summary>
        ///  此协议针对什么语言有效:
/// - `zh-CN`: 简体中文
/// - `zh-TW`: 繁体中文
/// - `en-US`: 英文
/// - `ja-JP`: 日语
/// 
        /// </summary>
        public enum lang
        {
            [EnumMember(Value="zh-CN")]
            ZH_CN,
            [EnumMember(Value="en-US")]
            EN_US,
            [EnumMember(Value="zh-TW")]
            ZH_TW,
            [EnumMember(Value="ja-JP")]
            JA_JP,
        }
    }
}