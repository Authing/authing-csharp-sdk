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
    /// UpdateTenantAppqrcodeState 的模型
    /// </summary>
    public partial class UpdateTenantAppqrcodeState
    {
        /// <summary>
        ///  是否允许开启扫码登录
        /// </summary>
        [JsonProperty("enabled")]
        public bool  Enabled {get;set;}
    }
}