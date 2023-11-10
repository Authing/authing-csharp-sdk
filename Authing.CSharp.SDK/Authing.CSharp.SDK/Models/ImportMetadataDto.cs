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
    /// ImportMetadataDto 的模型
    /// </summary>
    public partial class ImportMetadataDto
    {
        /// <summary>
        ///  导入的 json 文件地址
        /// </summary>
        [JsonProperty("file")]
        public string  File {get;set;}
    }
}