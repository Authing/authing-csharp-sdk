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
    /// CostGetOrderPayDetail 的模型
    /// </summary>
    public partial class CostGetOrderPayDetail
    {
        /// <summary>
        ///  订单号
        /// </summary>
        [JsonProperty("orderNo")]
        public string  OrderNo  {get;set;}
        /// <summary>
        ///  渠道订单号
        /// </summary>
        [JsonProperty("channelOrderNo")]
        public string  ChannelOrderNo  {get;set;}
        /// <summary>
        ///  渠道订单号
        /// </summary>
        [JsonProperty("paidAmount")]
        public string  PaidAmount  {get;set;}
        /// <summary>
        ///  支付时间
        /// </summary>
        [JsonProperty("paidTime")]
        public string  PaidTime  {get;set;}
        /// <summary>
        ///  支付账号
        /// </summary>
        [JsonProperty("paidAccountNo")]
        public string  PaidAccountNo  {get;set;}
        /// <summary>
        ///  支付状态
        /// </summary>
        [JsonProperty("payStatus")]
        public string  PayStatus  {get;set;}
        /// <summary>
        ///  创建时间
        /// </summary>
        [JsonProperty("createTime")]
        public string  CreateTime  {get;set;}
        /// <summary>
        ///  支付方式
        /// </summary>
        [JsonProperty("payType")]
        public string  PayType  {get;set;}
    }
}