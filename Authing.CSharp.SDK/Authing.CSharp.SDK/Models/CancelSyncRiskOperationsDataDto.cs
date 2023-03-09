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
    /// CancelSyncRiskOperationsDataDto 的模型
    /// </summary>
    public partial class CancelSyncRiskOperationsDataDto
    {
        /// <summary>
        ///  成功取消的风险操作任务
        /// </summary>
        [JsonProperty("successList")]
        public List<long>  SuccessList  {get;set;}
        /// <summary>
        ///  取消失败的风险操作任务
        /// </summary>
        [JsonProperty("faildList")]
        public List<long>  FaildList  {get;set;}
    }
}