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
    /// UpdateAccessKeyDto 的模型
    /// </summary>
    public partial class UpdateAccessKeyDto
    {
        /// <summary>
        ///  密钥是否生效
        /// </summary>
        [JsonProperty("enable")]
        public bool  Enable  {get;set;}
        /// <summary>
        ///  AccessKey ID
        /// </summary>
        [JsonProperty("accessKeyId")]
        public string  AccessKeyId  {get;set;}
    }
}