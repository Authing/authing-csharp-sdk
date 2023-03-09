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
    /// GetUserResourcePermissionListDataDto 的模型
    /// </summary>
    public partial class GetUserResourcePermissionListDataDto
    {
        /// <summary>
        ///  权限列表
        /// </summary>
        [JsonProperty("permissionList")]
        public List<GetUserResourcePermissionList>  PermissionList  {get;set;}
    }
}