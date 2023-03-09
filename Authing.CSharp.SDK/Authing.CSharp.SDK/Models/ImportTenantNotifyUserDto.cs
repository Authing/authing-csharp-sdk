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
    /// ImportTenantNotifyUserDto 的模型
    /// </summary>
    public partial class ImportTenantNotifyUserDto
    {
        /// <summary>
        ///  导入记录 id
        /// </summary>
        [JsonProperty("importId")]
        public string  ImportId {get;set;} 
        /// <summary>
        ///  页码
        /// </summary>
        [JsonProperty("page")]
        public int  Page {get;set;} =1;
        /// <summary>
        ///  每页获取的数据量
        /// </summary>
        [JsonProperty("limit")]
        public int  Limit {get;set;} =10;
    }
}