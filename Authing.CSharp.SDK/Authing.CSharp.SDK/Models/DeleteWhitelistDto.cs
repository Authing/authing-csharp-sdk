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
    /// DeleteWhitelistDto 的模型
    /// </summary>
    public partial class DeleteWhitelistDto
    {
        /// <summary>
        ///  白名单类型
        /// </summary>
        [JsonProperty("type")]
        public type  Type {get;set;}
        /// <summary>
        ///  类型参数
        /// </summary>
        [JsonProperty("list")]
        public List<string>  List {get;set;}
    }
    public partial class DeleteWhitelistDto
    {
        /// <summary>
        ///  白名单类型
        /// </summary>
        public enum type
        {
            [EnumMember(Value="USERNAME")]
            USERNAME,
            [EnumMember(Value="EMAIL")]
            EMAIL,
            [EnumMember(Value="PHONE")]
            PHONE,
        }
    }
}