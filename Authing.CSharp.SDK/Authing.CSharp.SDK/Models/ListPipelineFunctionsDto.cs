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
    /// ListPipelineFunctionsDto 的模型
    /// </summary>
    public partial class ListPipelineFunctionsDto
    {
        /// <summary>
        ///  通过函数的触发场景进行筛选（可选，默认返回所有）：
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
        public string  Scene {get;set;} 
    }
}