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
    /// PipelineFunctionDto 的模型
    /// </summary>
    public partial class PipelineFunctionDto
    {
        /// <summary>
        ///  函数 ID
        /// </summary>
        [JsonProperty("funcId")]
        public string  FuncId {get;set;}
        /// <summary>
        ///  函数名称
        /// </summary>
        [JsonProperty("funcName")]
        public string  FuncName {get;set;}
        /// <summary>
        ///  函数描述
        /// </summary>
        [JsonProperty("funcDescription")]
        public string  FuncDescription {get;set;}
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
        public scene  Scene {get;set;}
        /// <summary>
        ///  函数创建时间
        /// </summary>
        [JsonProperty("createdAt")]
        public string  CreatedAt {get;set;}
        /// <summary>
        ///  函数修改时间
        /// </summary>
        [JsonProperty("updatedAt")]
        public string  UpdatedAt {get;set;}
        /// <summary>
        ///  是否异步执行。设置为异步执行的函数不会阻塞整个流程的执行，适用于异步通知的场景，比如飞书群通知、钉钉群通知等。
        /// </summary>
        [JsonProperty("isAsynchronous")]
        public bool  IsAsynchronous {get;set;}
        /// <summary>
        ///  函数运行超时时间，最短为 1 秒，最长为 60 秒，默认为 3 秒。
        /// </summary>
        [JsonProperty("timeout")]
        public long  Timeout {get;set;}
        /// <summary>
        ///  如果函数运行超时，是否终止整个流程，默认为否。
        /// </summary>
        [JsonProperty("terminateOnTimeout")]
        public bool  TerminateOnTimeout {get;set;}
        /// <summary>
        ///  函数源代码
        /// </summary>
        [JsonProperty("sourceCode")]
        public string  SourceCode {get;set;}
        /// <summary>
        ///  函数当前状态：
/// - `uploading`: 上传中
/// - `success`: 上传成功
/// - `failed`: 上传失败
/// 
        /// </summary>
        [JsonProperty("status")]
        public status  Status {get;set;}
        /// <summary>
        ///  上传失败的错误提示
        /// </summary>
        [JsonProperty("uploadErrMsg")]
        public string  UploadErrMsg {get;set;}
        /// <summary>
        ///  此 Pipeline 是否被启用
        /// </summary>
        [JsonProperty("enabled")]
        public bool  Enabled {get;set;}
    }
    public partial class PipelineFunctionDto
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
            [EnumMember(Value="PRE_REGISTER")]
            PRE_REGISTER,
            [EnumMember(Value="POST_REGISTER")]
            POST_REGISTER,
            [EnumMember(Value="PRE_AUTHENTICATION")]
            PRE_AUTHENTICATION,
            [EnumMember(Value="POST_AUTHENTICATION")]
            POST_AUTHENTICATION,
            [EnumMember(Value="PRE_OIDC_ID_TOKEN_ISSUED")]
            PRE_OIDC_ID_TOKEN_ISSUED,
            [EnumMember(Value="PRE_OIDC_ACCESS_TOKEN_ISSUED")]
            PRE_OIDC_ACCESS_TOKEN_ISSUED,
            [EnumMember(Value="PRE_COMPLETE_USER_INFO")]
            PRE_COMPLETE_USER_INFO,
        }
        /// <summary>
        ///  函数当前状态：
/// - `uploading`: 上传中
/// - `success`: 上传成功
/// - `failed`: 上传失败
/// 
        /// </summary>
        public enum status
        {
            [EnumMember(Value="uploading")]
            UPLOADING,
            [EnumMember(Value="success")]
            SUCCESS,
            [EnumMember(Value="failed")]
            FAILED,
        }
    }
}