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
    /// errorEmailMsg 的模型
    /// </summary>
    public partial class errorEmailMsg
    {
        /// <summary>
        ///  邮箱地址
        /// </summary>
        [JsonProperty("email")]
        public string  Email  {get;set;}
        /// <summary>
        ///  错误信息描述
        /// </summary>
        [JsonProperty("message")]
        public string  Message  {get;set;}
    }
}