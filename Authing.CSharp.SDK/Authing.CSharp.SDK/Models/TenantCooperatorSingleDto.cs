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
    /// TenantCooperatorSingleDto 的模型
    /// </summary>
    public partial class TenantCooperatorSingleDto
    {
        /// <summary>
        ///  菜单
        /// </summary>
        [JsonProperty("list")]
        public List<string>  List {get;set;}
        /// <summary>
        ///  策略
        /// </summary>
        [JsonProperty("authorizedPoliciesCode")]
        public List<string>  AuthorizedPoliciesCode {get;set;}
    }
}