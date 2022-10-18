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
    /// UpdatePipelineOrderDto 的模型
    /// </summary>
    public partial class UpdatePipelineOrderDto
    {
        /// <summary>
        ///  新的排序方式，按照函数 ID 的先后顺序进行排列。
        /// </summary>
        [JsonProperty("order")]
        public List<string> Order { get; set; }
        /// <summary>
        ///  函数的触发场景：
        /// - `PRE_REGISTER`: 注册前
        /// - `POST_REGISTER`: 注册后
        /// - `PRE_AUTHENTICATION`: 认证前
        /// - `POST_AUTHENTICATION`: 认证后
        /// - `PRE_OIDC_ID_TOKEN_ISSUED`: OIDC ID Token 签发前
        /// - `PRE_OIDC_ACCESS_TOKEN_ISSUED`: OIDC Access Token 签发前
        /// - `PRE_COMPLETE_USER_INFO`: 补全用户信息前
        /// 
        /// </summary>
        [JsonProperty("scene")]
        public scene Scene { get; set; }
    }
    public partial class UpdatePipelineOrderDto
    {
        /// <summary>
        ///  函数的触发场景：
        /// - `PRE_REGISTER`: 注册前
        /// - `POST_REGISTER`: 注册后
        /// - `PRE_AUTHENTICATION`: 认证前
        /// - `POST_AUTHENTICATION`: 认证后
        /// - `PRE_OIDC_ID_TOKEN_ISSUED`: OIDC ID Token 签发前
        /// - `PRE_OIDC_ACCESS_TOKEN_ISSUED`: OIDC Access Token 签发前
        /// - `PRE_COMPLETE_USER_INFO`: 补全用户信息前
        /// 
        /// </summary>
        public enum scene
        {
            [EnumMember(Value = "PRE_REGISTER")]
            PRE_REGISTER,
            [EnumMember(Value = "POST_REGISTER")]
            POST_REGISTER,
            [EnumMember(Value = "PRE_AUTHENTICATION")]
            PRE_AUTHENTICATION,
            [EnumMember(Value = "POST_AUTHENTICATION")]
            POST_AUTHENTICATION,
            [EnumMember(Value = "PRE_OIDC_ID_TOKEN_ISSUED")]
            PRE_OIDC_ID_TOKEN_ISSUED,
            [EnumMember(Value = "PRE_OIDC_ACCESS_TOKEN_ISSUED")]
            PRE_OIDC_ACCESS_TOKEN_ISSUED,
            [EnumMember(Value = "PRE_COMPLETE_USER_INFO")]
            PRE_COMPLETE_USER_INFO,
        }
    }
}