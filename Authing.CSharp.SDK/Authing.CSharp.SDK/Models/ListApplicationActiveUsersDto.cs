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
    /// ListApplicationActiveUsersDto 的模型
    /// </summary>
    public partial class ListApplicationActiveUsersDto
    {
        /// <summary>
        ///  应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public string  AppId {get;set;}
        /// <summary>
        ///  可选项
        /// </summary>
        [JsonProperty("options")]
        public ListApplicationActiveUsersOptionsDto  Options {get;set;}
    }
}