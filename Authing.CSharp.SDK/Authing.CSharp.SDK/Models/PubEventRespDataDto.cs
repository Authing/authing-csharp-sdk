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
    /// PubEventRespDataDto 的模型
    /// </summary>
    public partial class PubEventRespDataDto
    {
        /// <summary>
        ///  发送是否成功
        /// </summary>
        [JsonProperty("success")]
        public bool  Success  {get;set;}
        /// <summary>
        ///  发送失败的错误提示
        /// </summary>
        [JsonProperty("errMsg")]
        public bool  ErrMsg  {get;set;}
    }
}