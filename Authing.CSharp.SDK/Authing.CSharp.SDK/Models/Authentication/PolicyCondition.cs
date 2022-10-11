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
    /// PolicyCondition 的模型
    /// </summary>
    public partial class PolicyCondition
    {
        /// <summary>
        ///  Condition Param
        /// </summary>
        [JsonProperty("param")]
        public    param   Param    {get;set;}
        /// <summary>
        ///  Condition Operator
        /// </summary>
        [JsonProperty("operator")]
        public    @operator   Operator    {get;set;}
        /// <summary>
        ///  Condition Value
        /// </summary>
        [JsonProperty("value")]
        public    string   Value    {get;set;}
    }
    public partial class PolicyCondition
    {
        /// <summary>
        ///  Condition Param
        /// </summary>
        public enum param
        {
            [EnumMember(Value="UserPoolId")]
            USER_POOL_ID,
            [EnumMember(Value="AppId")]
            APP_ID,
            [EnumMember(Value="RequestFrom")]
            REQUEST_FROM,
            [EnumMember(Value="UserId")]
            USER_ID,
            [EnumMember(Value="UserArn")]
            USER_ARN,
            [EnumMember(Value="CurrentTime")]
            CURRENT_TIME,
            [EnumMember(Value="EpochTime")]
            EPOCH_TIME,
            [EnumMember(Value="SourceIp")]
            SOURCE_IP,
            [EnumMember(Value="User")]
            USER,
            [EnumMember(Value="MultiFactorAuthPresent")]
            MULTI_FACTOR_AUTH_PRESENT,
            [EnumMember(Value="MultiFactorAuthAge")]
            MULTI_FACTOR_AUTH_AGE,
            [EnumMember(Value="UserAgent")]
            USER_AGENT,
            [EnumMember(Value="Referer")]
            REFERER,
            [EnumMember(Value="Device")]
            DEVICE,
            [EnumMember(Value="OS")]
            OS,
            [EnumMember(Value="Country")]
            COUNTRY,
            [EnumMember(Value="Province")]
            PROVINCE,
            [EnumMember(Value="City")]
            CITY,
            [EnumMember(Value="DeviceChanged")]
            DEVICE_CHANGED,
            [EnumMember(Value="DeviceUntrusted")]
            DEVICE_UNTRUSTED,
            [EnumMember(Value="ProxyUntrusted")]
            PROXY_UNTRUSTED,
            [EnumMember(Value="LoggedInApps")]
            LOGGED_IN_APPS,
            [EnumMember(Value="Namespace")]
            NAMESPACE,
        }
        /// <summary>
        ///  Condition Operator
        /// </summary>
        public enum @operator
        {
            [EnumMember(Value="Bool")]
            BOOL,
            [EnumMember(Value="DateEquals")]
            DATE_EQUALS,
            [EnumMember(Value="DateNotEquals")]
            DATE_NOT_EQUALS,
            [EnumMember(Value="DateLessThan")]
            DATE_LESS_THAN,
            [EnumMember(Value="DateLessThanEquals")]
            DATE_LESS_THAN_EQUALS,
            [EnumMember(Value="DateGreaterThan")]
            DATE_GREATER_THAN,
            [EnumMember(Value="DateGreaterThanEquals")]
            DATE_GREATER_THAN_EQUALS,
            [EnumMember(Value="IpAddress")]
            IP_ADDRESS,
            [EnumMember(Value="NotIpAddress")]
            NOT_IP_ADDRESS,
            [EnumMember(Value="NumericEquals")]
            NUMERIC_EQUALS,
            [EnumMember(Value="NumericNotEquals")]
            NUMERIC_NOT_EQUALS,
            [EnumMember(Value="NumericLessThan")]
            NUMERIC_LESS_THAN,
            [EnumMember(Value="NumericLessThanEquals")]
            NUMERIC_LESS_THAN_EQUALS,
            [EnumMember(Value="NumericGreaterThan")]
            NUMERIC_GREATER_THAN,
            [EnumMember(Value="NumericGreaterThanEquals")]
            NUMERIC_GREATER_THAN_EQUALS,
            [EnumMember(Value="StringEquals")]
            STRING_EQUALS,
            [EnumMember(Value="StringNotEquals")]
            STRING_NOT_EQUALS,
            [EnumMember(Value="StringEqualsIgnoreCase")]
            STRING_EQUALS_IGNORE_CASE,
            [EnumMember(Value="StringNotEqualsIgnoreCase")]
            STRING_NOT_EQUALS_IGNORE_CASE,
            [EnumMember(Value="StringLike")]
            STRING_LIKE,
            [EnumMember(Value="StringNotLike")]
            STRING_NOT_LIKE,
            [EnumMember(Value="ListContains")]
            LIST_CONTAINS,
        }
    }
}