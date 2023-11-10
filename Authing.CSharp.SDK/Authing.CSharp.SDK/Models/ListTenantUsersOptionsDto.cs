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
    /// ListTenantUsersOptionsDto 的模型
    /// </summary>
    public partial class ListTenantUsersOptionsDto
    {
        /// <summary>
        ///  分页配置
        /// </summary>
        [JsonProperty("pagination")]
        public PaginationDto  Pagination {get;set;}
    }
}