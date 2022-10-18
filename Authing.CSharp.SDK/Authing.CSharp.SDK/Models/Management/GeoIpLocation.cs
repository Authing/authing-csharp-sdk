using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models.Management;

namespace Authing.CSharp.SDK.Models.Management
{
    /// <summary>
    /// GeoIpLocation 的模型
    /// </summary>
    public partial class GeoIpLocation
    {
        /// <summary>
        ///  经度
        /// </summary>
        [JsonProperty("lon")]
        public long Lon { get; set; }
        /// <summary>
        ///  纬度
        /// </summary>
        [JsonProperty("lat")]
        public long Lat { get; set; }
    }
}