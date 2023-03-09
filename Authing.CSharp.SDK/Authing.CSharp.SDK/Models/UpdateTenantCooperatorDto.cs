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
    /// UpdateTenantCooperatorDto 的模型
    /// </summary>
    public partial class UpdateTenantCooperatorDto
    {
        /// <summary>
        ///  是否授权 API
        /// </summary>
        [JsonProperty("apiAuthorized")]
        public bool  ApiAuthorized  {get;set;}
        /// <summary>
        ///  策略
        /// </summary>
        [JsonProperty("policies")]
        public List<string>  Policies  {get;set;}
    }
}