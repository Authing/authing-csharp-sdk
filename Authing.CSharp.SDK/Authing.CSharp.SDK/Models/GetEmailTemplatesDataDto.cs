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
    /// GetEmailTemplatesDataDto 的模型
    /// </summary>
    public partial class GetEmailTemplatesDataDto
    {
        /// <summary>
        ///  模版列表
        /// </summary>
        [JsonProperty("templates")]
        public List<EmailTemplateDto>  Templates  {get;set;}
        /// <summary>
        ///  模版类型列表
        /// </summary>
        [JsonProperty("categories")]
        public List<EmailTemplateCategoryDto>  Categories  {get;set;}
    }
}