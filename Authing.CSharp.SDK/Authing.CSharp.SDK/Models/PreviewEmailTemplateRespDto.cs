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
    /// PreviewEmailTemplateRespDto 的模型
    /// </summary>
    public partial class PreviewEmailTemplateRespDto
    {
        /// <summary>
        ///  响应数据
        /// </summary>
        [JsonProperty("data")]
        public PreviewEmailTemplateDataDto  Data {get;set;}
    }
}