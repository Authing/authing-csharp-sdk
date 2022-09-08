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
    /// DeleteUsersBatchDto 的模型
    /// </summary>
    public partial class DeleteUsersBatchDto
    {
        /// <summary>
        ///  用户 ID 列表
        /// </summary>
        [JsonProperty("userIds")]
        public    List<string>   UserIds    {get;set;}
        /// <summary>
        ///  可选参数
        /// </summary>
        [JsonProperty("options")]
        public    DeleteUsersBatchOptionsDto   Options    {get;set;}
    }
}