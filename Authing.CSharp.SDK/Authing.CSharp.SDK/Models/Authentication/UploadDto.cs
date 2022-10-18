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
    /// UploadDto 的模型
    /// </summary>
    public partial class UploadDto
    {
        /// <summary>
        ///  上传的目录
        /// </summary>
        [JsonProperty("folder")]
        public string Folder { get; set; }
        /// <summary>
        ///  是否为私有资源
        /// </summary>
        [JsonProperty("isPrivate")]
        public bool IsPrivate { get; set; }
    }
}