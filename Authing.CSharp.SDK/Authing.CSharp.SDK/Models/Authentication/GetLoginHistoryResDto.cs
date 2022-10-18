using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class GetLoginHistoryResDto
    {
        /// <summary>
        /// 业务状态码，可以通过此状态码判断操作是否成功，200 表示成功
        /// </summary>
        [JsonProperty("statusCode")]
        public long StatusCode { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 细分错误码，可通过此错误码得到具体的错误类型
        /// </summary>
        [JsonProperty("apicode")]
        public long ApiCode { get; set; }

        [JsonProperty("data")]
        public GetLoginHistoryRes data { get; set; }
    }

    public class GetLoginHistoryRes
    {
        /// <summary>
        /// 记录总数
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 记录列表
        /// </summary>
        [JsonProperty("list")]
        public List<LoginHistory> List { get; set; }
    }

    public class LoginHistory
    {
        /// <summary>
        /// 应用 ID
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 应用名称
        /// </summary>
        public string AppName { get; set; }
        /// <summary>
        /// 应用登录地址
        /// </summary>
        public string AppLoginUrl { get; set; }
        /// <summary>
        /// 应用 Logo
        /// </summary>
        public string AppLogo { get; set; }
        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime LoginAt { get; set; }
        /// <summary>
        /// 登录时使用的客户端 IP
        /// </summary>
        public string ClientIp { get; set; }
        /// <summary>
        /// 是否登录成功
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 登录失败时的具体错误信息
        /// </summary>
        public string ErrorMessage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UserAgent { get; set; }
        /// <summary>
        /// 解析过后的 User Agent
        /// </summary>
        public Parseduseragent ParsedUserAgent { get; set; }
        /// <summary>
        /// 使用的登录方式
        /// </summary>
        public string LoginMethod { get; set; }
        /// <summary>
        /// 地理位置
        /// </summary>
        public Geoip Geoip { get; set; }
    }

    public class Parseduseragent
    {
        /// <summary>
        /// 使用的设备类型
        /// </summary>
        public string Device { get; set; }
        /// <summary>
        /// 浏览器名称
        /// </summary>
        public string Browser { get; set; }
        /// <summary>
        /// 操作系统
        /// </summary>
        public string Os { get; set; }
    }

    public class Geoip
    {
        /// <summary>
        /// 地理位置
        /// </summary>
        public Location Location { get; set; }
        public string Country_name { get; set; }
        public string Country_code2 { get; set; }
        public string Country_code3 { get; set; }
        public string Region_name { get; set; }
        public string Region_code { get; set; }
        /// <summary>
        /// 城市名称
        /// </summary>
        public string City_name { get; set; }

        public string Continent_code { get; set; }
        /// <summary>
        /// 时区
        /// </summary>
        public string Timezone { get; set; }
    }

    public class Location
    {
        /// <summary>
        /// 经度
        /// </summary>
        public float Lon { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public float Lat { get; set; }
    }

}
