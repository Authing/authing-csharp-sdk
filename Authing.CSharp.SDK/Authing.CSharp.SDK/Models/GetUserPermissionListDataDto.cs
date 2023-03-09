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
    /// GetUserPermissionListDataDto 的模型
    /// </summary>
    public partial class GetUserPermissionListDataDto
    {
        /// <summary>
        ///  用户权限列表
        /// </summary>
        [JsonProperty("userPermissionList")]
        public List<UserPermissionListDto>  UserPermissionList  {get;set;}
    }
}