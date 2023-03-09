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
    /// GetFastpassQRCodeRelationAppsDto 的模型
    /// </summary>
    public partial class GetFastpassQRCodeRelationAppsDto
    {
        /// <summary>
        ///  关联的客户端应用信息
        /// </summary>
        [JsonProperty("relationApps")]
        public List<FastpassQRCodeRelationAppDto>  RelationApps  {get;set;}
    }
}