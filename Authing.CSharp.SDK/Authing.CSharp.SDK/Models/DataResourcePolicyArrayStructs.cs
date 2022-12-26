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
    /// DataResourcePolicyArrayStructs 的模型
    /// </summary>
    public partial class DataResourcePolicyArrayStructs
    {
        /// <summary>
        ///  数据策略所拥有对某一个数据资源的操作权限，所有操作（ALL）,特定操作（SPECIAL）
        /// </summary>
        [JsonProperty("operationType")]
        public string  OperationType {get;set;}
        /// <summary>
        ///  数据权限列表，每个策略下所有的数据权限节点
        /// </summary>
        [JsonProperty("actionList")]
        public List<ArrayOrStringActionDto>  ActionList {get;set;}
    }
}