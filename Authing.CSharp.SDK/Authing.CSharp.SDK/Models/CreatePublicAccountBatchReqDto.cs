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
    /// CreatePublicAccountBatchReqDto 的模型
    /// </summary>
    public partial class CreatePublicAccountBatchReqDto
    {
        /// <summary>
        ///  公共账号列表
        /// </summary>
        [JsonProperty("list")]
        public List<CreatePublicAccountReqDto>  List {get;set;}
        /// <summary>
        ///  可选参数
        /// </summary>
        [JsonProperty("options")]
        public CreatePublicAccountOptionsDto  Options {get;set;}
    }
}