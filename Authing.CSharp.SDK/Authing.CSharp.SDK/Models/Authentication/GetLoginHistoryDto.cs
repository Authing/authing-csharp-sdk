using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Authing.CSharp.SDK.Models.Authentication
{
    /// <summary>
    /// 获取登录日志参数类
    /// </summary>
    public class GetLoginHistoryDto
    {
        /// <summary>
        /// 应用 ID，可根据应用 ID 筛选。默认不传获取所有应用的登录历史
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// 客户端 IP，可根据登录时的客户端 IP 进行筛选。默认不传获取所有登录 IP 的登录历史
        /// </summary>
        [JsonProperty("clientIp")]
        public string ClientIp { get; set; }

        /// <summary>
        /// 是否登录成功，可根据是否登录成功进行筛选。默认不传获取的记录中既包含成功也包含失败的的登录历史
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 登录方式，可根据登录方式进行筛选。默认不传获取所有登录方式对应的登录历史
        /// </summary>
        [JsonProperty("loginMethod")]
        public bool LoginMethod { get; set; }

        /// <summary>
        /// 开始时间，为单位为毫秒的时间戳
        /// </summary>
        [JsonProperty("start")]
        public ulong Start { get; set; }

        /// <summary>
        /// 结束时间，为单位为毫秒的时间戳
        /// </summary>
        [JsonProperty("end")]
        public ulong End { get; set; }
    }
}
