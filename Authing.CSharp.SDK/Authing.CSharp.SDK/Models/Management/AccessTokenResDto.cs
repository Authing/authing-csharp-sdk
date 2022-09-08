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
    /// AccessTokenResDto 的模型
    /// </summary>
    public partial class AccessTokenResDto
    {
        /// <summary>
        ///  Access Token 内容
        /// </summary>
        [JsonProperty("access_token")]
        public    string   Access_token    {get;set;}
        /// <summary>
        ///  token 有效时间
        /// </summary>
        [JsonProperty("expires_in")]
        public    long   Expires_in    {get;set;}
    }
}