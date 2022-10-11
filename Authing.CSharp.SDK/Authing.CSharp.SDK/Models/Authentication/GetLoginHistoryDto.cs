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
    /// GetLoginHistoryDto 的模型
    /// </summary>
    public partial class GetLoginHistoryDto
    {
        /// <summary>
        ///  应用 ID，可根据应用 ID 筛选。默认不传获取所有应用的登录历史。
        /// </summary>
        [JsonProperty("appId")]
        public    object   AppId    {get;set;}
        /// <summary>
        ///  客户端 IP，可根据登录时的客户端 IP 进行筛选。默认不传获取所有登录 IP 的登录历史。
        /// </summary>
        [JsonProperty("clientIp")]
        public    object   ClientIp    {get;set;}
        /// <summary>
        ///  是否登录成功，可根据是否登录成功进行筛选。默认不传获取的记录中既包含成功也包含失败的的登录历史。
        /// </summary>
        [JsonProperty("success")]
        public    object   Success    {get;set;}
        /// <summary>
        ///  开始时间，为单位为毫秒的时间戳
        /// </summary>
        [JsonProperty("start")]
        public    object   Start    {get;set;}
        /// <summary>
        ///  结束时间，为单位为毫秒的时间戳
        /// </summary>
        [JsonProperty("end")]
        public    object   End    {get;set;}
        /// <summary>
        ///  当前页数，从 1 开始
        /// </summary>
        [JsonProperty("page")]
        public    object   Page    {get;set;}
        /// <summary>
        ///  每页数目，最大不能超过 50，默认为 10
        /// </summary>
        [JsonProperty("limit")]
        public    object   Limit    {get;set;}
    }
}