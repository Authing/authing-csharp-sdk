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
    /// GetOrderPayDetailDto 的模型
    /// </summary>
    public partial class GetOrderPayDetailDto
    {
        /// <summary>
        ///  订单号
        /// </summary>
        [JsonProperty("orderNo")]
        public string  OrderNo {get;set;} 
    }
}