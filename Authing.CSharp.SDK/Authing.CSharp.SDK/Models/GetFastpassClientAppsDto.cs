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
    /// GetFastpassClientAppsDto 的模型
    /// </summary>
    public partial class GetFastpassClientAppsDto
    {
        [JsonProperty("qrcodeId")]
        public string  QrcodeId {get;set;} 
        [JsonProperty("appId")]
        public string  AppId {get;set;} 
    }
}