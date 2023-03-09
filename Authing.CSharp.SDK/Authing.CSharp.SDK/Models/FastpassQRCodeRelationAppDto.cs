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
    /// FastpassQRCodeRelationAppDto 的模型
    /// </summary>
    public partial class FastpassQRCodeRelationAppDto
    {
        /// <summary>
        ///  应用 ID
        /// </summary>
        [JsonProperty("id")]
        public string  Id  {get;set;}
        /// <summary>
        ///  应用名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name  {get;set;}
        /// <summary>
        ///  应用 logo
        /// </summary>
        [JsonProperty("logo")]
        public string  Logo  {get;set;}
    }
}