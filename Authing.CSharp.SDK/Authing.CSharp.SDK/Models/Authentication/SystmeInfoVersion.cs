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
    /// SystmeInfoVersion 的模型
    /// </summary>
    public partial class SystmeInfoVersion
    {
        /// <summary>
        ///  Authing 核心服务版本号
        /// </summary>
        [JsonProperty("server")]
        public    string   Server    {get;set;}
        /// <summary>
        ///  Authing 控制台版本号
        /// </summary>
        [JsonProperty("console")]
        public    string   Console    {get;set;}
        /// <summary>
        ///  Authing 托管登录页版本号
        /// </summary>
        [JsonProperty("login")]
        public    string   Login    {get;set;}
    }
}