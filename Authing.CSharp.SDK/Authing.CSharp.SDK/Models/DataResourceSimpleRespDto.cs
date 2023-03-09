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
    /// DataResourceSimpleRespDto 的模型
    /// </summary>
    public partial class DataResourceSimpleRespDto
    {
        /// <summary>
        ///  数据权限所属的数据资源 ID
        /// </summary>
        [JsonProperty("resourceId")]
        public string  ResourceId  {get;set;}
        /// <summary>
        ///  数据权限所属的数据资源名称
        /// </summary>
        [JsonProperty("resourceName")]
        public string  ResourceName  {get;set;}
    }
}