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
    /// FastpassUserInfoDto 的模型
    /// </summary>
    public partial class FastpassUserInfoDto
    {
        /// <summary>
        ///  用户 ID
        /// </summary>
        [JsonProperty("id")]
        public string  Id  {get;set;}
        /// <summary>
        ///  用户名称
        /// </summary>
        [JsonProperty("displayName")]
        public string  DisplayName  {get;set;}
        /// <summary>
        ///  用户头像地址
        /// </summary>
        [JsonProperty("photo")]
        public string  Photo  {get;set;}
    }
}