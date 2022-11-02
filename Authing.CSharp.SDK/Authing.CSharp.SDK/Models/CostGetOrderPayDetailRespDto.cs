using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models;

   namespace Authing.CSharp.SDK.Models
{
/// <summary>
/// CostGetOrderPayDetailRespDto 的模型
/// </summary>
public partial class CostGetOrderPayDetailRespDto
{
    /// <summary>
    ///  业务状态码，可以通过此状态码判断操作是否成功，200 表示成功。
    /// </summary>
    [JsonProperty("statusCode")]
    public long  StatusCode {get;set;}
    /// <summary>
    ///  描述信息
    /// </summary>
    [JsonProperty("message")]
    public string  Message {get;set;}
    /// <summary>
    ///  细分错误码，可通过此错误码得到具体的错误类型。
    /// </summary>
    [JsonProperty("apiCode")]
    public long  ApiCode {get;set;}
    /// <summary>
    ///  请求 ID。当请求失败时会返回。
    /// </summary>
    [JsonProperty("requestId")]
    public string  RequestId {get;set;}
    /// <summary>
    ///  订单号
    /// </summary>
    [JsonProperty("orderNo")]
    public string  OrderNo {get;set;}
    /// <summary>
    ///  渠道订单号
    /// </summary>
    [JsonProperty("channelOrderNo")]
    public string  ChannelOrderNo {get;set;}
    /// <summary>
    ///  渠道订单号
    /// </summary>
    [JsonProperty("paidAmount")]
    public string  PaidAmount {get;set;}
    /// <summary>
    ///  支付时间
    /// </summary>
    [JsonProperty("paidTime")]
    public string  PaidTime {get;set;}
    /// <summary>
    ///  支付账号
    /// </summary>
    [JsonProperty("paidAccountNo")]
    public string  PaidAccountNo {get;set;}
    /// <summary>
    ///  支付状态
    /// </summary>
    [JsonProperty("payStatus")]
    public string  PayStatus {get;set;}
    /// <summary>
    ///  创建时间
    /// </summary>
    [JsonProperty("createTime")]
    public string  CreateTime {get;set;}
    /// <summary>
    ///  支付方式
    /// </summary>
    [JsonProperty("payType")]
    public string  PayType {get;set;}
}
}