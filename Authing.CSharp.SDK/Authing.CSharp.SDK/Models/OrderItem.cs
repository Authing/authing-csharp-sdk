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
    /// OrderItem 的模型
    /// </summary>
    public partial class OrderItem
    {
        /// <summary>
        ///  订单号
        /// </summary>
        [JsonProperty("orderNo")]
        public string  OrderNo {get;set;}
        /// <summary>
        ///  套餐包名中文
        /// </summary>
        [JsonProperty("goodsName")]
        public string  GoodsName {get;set;}
        /// <summary>
        ///  套餐包名英文
        /// </summary>
        [JsonProperty("goodsNameEn")]
        public string  GoodsNameEn {get;set;}
        /// <summary>
        ///  单价
        /// </summary>
        [JsonProperty("goodsUnitPrice")]
        public string  GoodsUnitPrice {get;set;}
        /// <summary>
        ///  数量
        /// </summary>
        [JsonProperty("quantity")]
        public string  Quantity {get;set;}
        /// <summary>
        ///  实际金额
        /// </summary>
        [JsonProperty("actualAmount")]
        public string  ActualAmount {get;set;}
        /// <summary>
        ///  订单状态
        /// </summary>
        [JsonProperty("status")]
        public string  Status {get;set;}
        /// <summary>
        ///  订单类型
        /// </summary>
        [JsonProperty("orderType")]
        public string  OrderType {get;set;}
        /// <summary>
        ///  创建时间
        /// </summary>
        [JsonProperty("createTime")]
        public string  CreateTime {get;set;}
        /// <summary>
        ///  Licence：license 订单，Offline：线下交易，Eadmin：后台开通，SelfHelp：自助下单，Cdkey：Cdkey 活动兑换
        /// </summary>
        [JsonProperty("source")]
        public string  Source {get;set;}
    }
}