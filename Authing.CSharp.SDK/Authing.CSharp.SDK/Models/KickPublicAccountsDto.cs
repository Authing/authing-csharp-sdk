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
    /// KickPublicAccountsDto 的模型
    /// </summary>
    public partial class KickPublicAccountsDto
    {
        /// <summary>
        ///  APP ID 列表
        /// </summary>
        [JsonProperty("appIds")]
        public List<string>  AppIds {get;set;}
        /// <summary>
        ///  公共账号 ID
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId {get;set;}
        /// <summary>
        ///  可选参数
        /// </summary>
        [JsonProperty("options")]
        public KickPublicAccountsOptionsDto  Options {get;set;}
    }
}