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
    /// ListTenantsDto 的模型
    /// </summary>
    public partial class ListTenantsDto
    {
        /// <summary>
        ///  搜索关键字
        /// </summary>
        [JsonProperty("keywords")]
        public string  Keywords {get;set;} 
        /// <summary>
        ///  是否增加返回租户成员统计
        /// </summary>
        [JsonProperty("withMembersCount")]
        public bool  WithMembersCount {get;set;} 
        /// <summary>
        ///  增加返回租户下 app 简单信息
        /// </summary>
        [JsonProperty("withAppDetail")]
        public bool  WithAppDetail {get;set;} 
        /// <summary>
        ///  增加返回租户下创建者简单信息
        /// </summary>
        [JsonProperty("withCreatorDetail")]
        public bool  WithCreatorDetail {get;set;} 
        /// <summary>
        ///  增加返回租户下来源 app 简单信息
        /// </summary>
        [JsonProperty("withSourceAppDetail")]
        public bool  WithSourceAppDetail {get;set;} 
        /// <summary>
        ///  页码
        /// </summary>
        [JsonProperty("page")]
        public long  Page {get;set;} =1;
        /// <summary>
        ///  每页获取的数据量
        /// </summary>
        [JsonProperty("limit")]
        public long  Limit {get;set;} =10;
        /// <summary>
        ///  租户来源
        /// </summary>
        [JsonProperty("source")]
        public object  Source {get;set;} 
    }
}