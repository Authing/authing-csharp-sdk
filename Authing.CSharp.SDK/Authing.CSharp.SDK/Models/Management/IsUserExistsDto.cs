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
    /// IsUserExistsDto 的模型
    /// </summary>
    public partial class IsUserExistsDto
    {
        /// <summary>
        ///  用户是否存在
        /// </summary>
        [JsonProperty("exists")]
        public bool Exists { get; set; }
    }
}