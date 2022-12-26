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
    /// CheckParamsDataResourceRespDto 的模型
    /// </summary>
    public partial class CheckParamsDataResourceRespDto
    {
        /// <summary>
        ///  数据资源名称或者 Code 校验是否有效
        /// </summary>
        [JsonProperty("isValid")]
        public bool  IsValid {get;set;}
        /// <summary>
        ///  数据资源名称或者 Code 校验失败提示信息,如果校验成功, message 不返回
        /// </summary>
        [JsonProperty("message")]
        public string  Message {get;set;}
    }
}