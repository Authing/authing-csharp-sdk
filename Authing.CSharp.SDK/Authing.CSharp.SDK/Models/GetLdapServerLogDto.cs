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
    /// GetLdapServerLogDto 的模型
    /// </summary>
    public partial class GetLdapServerLogDto
    {
        /// <summary>
        ///  类型：1 访问日志，2 错误日志
        /// </summary>
        [JsonProperty("type")]
        public long  Type {get;set;} 
        /// <summary>
        ///  当前页,从 1 开始
        /// </summary>
        [JsonProperty("page")]
        public long  Page {get;set;} =1;
        /// <summary>
        ///  每页条数
        /// </summary>
        [JsonProperty("limit")]
        public long  Limit {get;set;} =10;
        /// <summary>
        ///  连接标识
        /// </summary>
        [JsonProperty("connection")]
        public long  Connection {get;set;} 
        /// <summary>
        ///  操作码
        /// </summary>
        [JsonProperty("operationNumber")]
        public long  OperationNumber {get;set;} 
        /// <summary>
        ///  错误码
        /// </summary>
        [JsonProperty("errorCode")]
        public long  ErrorCode {get;set;} 
        /// <summary>
        ///  消息内容
        /// </summary>
        [JsonProperty("message")]
        public string  Message {get;set;} 
        /// <summary>
        ///  开始时间-时间戳
        /// </summary>
        [JsonProperty("startTime")]
        public long  StartTime {get;set;} 
        /// <summary>
        ///  结束时间-时间戳
        /// </summary>
        [JsonProperty("endTime")]
        public long  EndTime {get;set;} 
    }
}