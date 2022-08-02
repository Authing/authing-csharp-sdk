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
    /// AuthorizedResourceDto 的模型
    /// </summary>
    public partial class AuthorizedResourceDto
    {
        /// <summary>
        ///  资源描述符
        /// </summary>
        [JsonProperty("resourceCode")]
        public    string   ResourceCode    {get;set;}
        /// <summary>
        ///  资源类型
        /// </summary>
        [JsonProperty("resourceType")]
        public    AuthorizedResourceDto.resourceType   ResourceType    {get;set;}
        /// <summary>
        ///  API URL
        /// </summary>
        [JsonProperty("apiIdentifier")]
        public    string   ApiIdentifier    {get;set;}
        /// <summary>
        ///  授权的操作列表
        /// </summary>
        [JsonProperty("actions")]
        public    List<string>   Actions    {get;set;}
        /// <summary>
        ///  允许还是拒绝
        /// </summary>
        [JsonProperty("effect")]
        public    AuthorizedResourceDto.effect   Effect    {get;set;}
    }
    public partial class AuthorizedResourceDto
    {
        /// <summary>
        ///  资源类型
        /// </summary>
        public enum resourceType
        {
            [EnumMember(Value="DATA")]
            DATA,
            [EnumMember(Value="API")]
            API,
            [EnumMember(Value="MENU")]
            MENU,
            [EnumMember(Value="BUTTON")]
            BUTTON,
        }
        /// <summary>
        ///  允许还是拒绝
        /// </summary>
        public enum effect
        {
            [EnumMember(Value="ALLOW")]
            ALLOW,
            [EnumMember(Value="DENY")]
            DENY,
        }
    }
}