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
    /// TenantCooperatorDto 的模型
    /// </summary>
    public partial class TenantCooperatorDto
    {
        /// <summary>
        ///  用户唯一 ID
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId  {get;set;}
        /// <summary>
        ///  类型
        /// </summary>
        [JsonProperty("type")]
        public string  Type  {get;set;}
        /// <summary>
        ///  是否external
        /// </summary>
        [JsonProperty("external")]
        public bool  External  {get;set;}
        /// <summary>
        ///  用户
        /// </summary>
        [JsonProperty("user")]
        public UserDto  User  {get;set;}
        /// <summary>
        ///  租户用户
        /// </summary>
        [JsonProperty("tenantUser")]
        public TenantUserDto  TenantUser  {get;set;}
    }
}