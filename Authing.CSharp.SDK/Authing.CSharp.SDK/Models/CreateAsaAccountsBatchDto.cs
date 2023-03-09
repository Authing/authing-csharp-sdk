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
    /// CreateAsaAccountsBatchDto 的模型
    /// </summary>
    public partial class CreateAsaAccountsBatchDto
    {
        /// <summary>
        ///  账号列表
        /// </summary>
        [JsonProperty("list")]
        public List<CreateAsaAccountsBatchItemDto>  List  {get;set;}
        /// <summary>
        ///  所属应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public string  AppId  {get;set;}
    }
}