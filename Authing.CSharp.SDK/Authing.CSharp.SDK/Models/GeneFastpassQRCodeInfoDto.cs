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
    /// GeneFastpassQRCodeInfoDto 的模型
    /// </summary>
    public partial class GeneFastpassQRCodeInfoDto
    {
        /// <summary>
        ///  二维码使用场景。
        /// </summary>
        [JsonProperty("scene")]
        public string  Scene  {get;set;}
        /// <summary>
        ///  二维码唯一 ID，可以通过此唯一 ID 查询二维码状态。
        /// </summary>
        [JsonProperty("qrcodeId")]
        public string  QrcodeId  {get;set;}
        /// <summary>
        ///  服务接口 Host 地址
        /// </summary>
        [JsonProperty("apiHost")]
        public string  ApiHost  {get;set;}
        /// <summary>
        ///  用户信息
        /// </summary>
        [JsonProperty("user")]
        public FastpassUserInfoDto  User  {get;set;}
        /// <summary>
        ///  当前用户生成二维码时登录的应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public string  AppId  {get;set;}
        /// <summary>
        ///  用户池信息
        /// </summary>
        [JsonProperty("userpool")]
        public FastpassUserInfoDto  Userpool  {get;set;}
    }
}