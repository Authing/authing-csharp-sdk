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
    /// RiskListPolicyCreateDto 的模型
    /// </summary>
    public partial class RiskListPolicyCreateDto
    {
        /// <summary>
        ///  限制类型列表,FORBID_LOGIN-禁止登录，FORBID_REGISTER-禁止注册
        /// </summary>
        [JsonProperty("limitList")]
        public limitList  LimitList {get;set;}
        /// <summary>
        ///  策略动作, ADD_IP_BLACK_LIST-添加IP黑名单，ADD_USER_BLACK_LIST-添加用户黑名单
        /// </summary>
        [JsonProperty("action")]
        public action  Action {get;set;}
        /// <summary>
        ///  移除类型，MANUAL-手动，SCHEDULE-策略, 目前只有手动
        /// </summary>
        [JsonProperty("removeType")]
        public removeType  RemoveType {get;set;}
        /// <summary>
        ///  事件状态类型，password_wrong-密码错误，account_wrong-账号错误
        /// </summary>
        [JsonProperty("eventStateType")]
        public eventStateType  EventStateType {get;set;}
        /// <summary>
        ///  次数阈值
        /// </summary>
        [JsonProperty("countThr")]
        public long  CountThr {get;set;}
        /// <summary>
        ///  时间范围，最近多少分钟
        /// </summary>
        [JsonProperty("timeRange")]
        public long  TimeRange {get;set;}
        /// <summary>
        ///  IP条件, NO_LIMIT-不限制，ONE-单个用户，与 ipCond 二者取一个
        /// </summary>
        [JsonProperty("userCond")]
        public userCond  UserCond {get;set;}
        /// <summary>
        ///  IP条件, NO_LIMIT-不限制，ONE-单个IP，与 userCond 二者取一个
        /// </summary>
        [JsonProperty("ipCond")]
        public ipCond  IpCond {get;set;}
        /// <summary>
        ///  操作USER的范围, ALL-所有，NOT_IN_WHITE_LIST-不在白名单中，与 ipRange 二者取一个
        /// </summary>
        [JsonProperty("userRange")]
        public userRange  UserRange {get;set;}
        /// <summary>
        ///  操作IP的范围, ALL-所有，NOT_IN_WHITE_LIST-不在白名单中，与 userRange 二者取一个
        /// </summary>
        [JsonProperty("ipRange")]
        public ipRange  IpRange {get;set;}
        /// <summary>
        ///  策略操作对象，目前只有 ip
        /// </summary>
        [JsonProperty("optObject")]
        public optObject  OptObject {get;set;}
    }
    public partial class RiskListPolicyCreateDto
    {
        /// <summary>
        ///  策略操作对象，目前只有 ip
        /// </summary>
        public enum optObject
        {
            [EnumMember(Value="IP")]
            IP,
            [EnumMember(Value="USER")]
            USER,
        }
        /// <summary>
        ///  操作IP的范围, ALL-所有，NOT_IN_WHITE_LIST-不在白名单中，与 userRange 二者取一个
        /// </summary>
        public enum ipRange
        {
            [EnumMember(Value="ALL")]
            ALL,
            [EnumMember(Value="NOT_IN_WHITE_LIST")]
            NOT_IN_WHITE_LIST,
        }
        /// <summary>
        ///  操作USER的范围, ALL-所有，NOT_IN_WHITE_LIST-不在白名单中，与 ipRange 二者取一个
        /// </summary>
        public enum userRange
        {
            [EnumMember(Value="ALL")]
            ALL,
            [EnumMember(Value="NOT_IN_WHITE_LIST")]
            NOT_IN_WHITE_LIST,
        }
        /// <summary>
        ///  IP条件, NO_LIMIT-不限制，ONE-单个IP，与 userCond 二者取一个
        /// </summary>
        public enum ipCond
        {
            [EnumMember(Value="NO_LIMIT")]
            NO_LIMIT,
            [EnumMember(Value="ONE")]
            ONE,
        }
        /// <summary>
        ///  IP条件, NO_LIMIT-不限制，ONE-单个用户，与 ipCond 二者取一个
        /// </summary>
        public enum userCond
        {
            [EnumMember(Value="NO_LIMIT")]
            NO_LIMIT,
            [EnumMember(Value="ONE")]
            ONE,
        }
        /// <summary>
        ///  事件状态类型，password_wrong-密码错误，account_wrong-账号错误
        /// </summary>
        public enum eventStateType
        {
            [EnumMember(Value="password_wrong")]
            PASSWORD_WRONG,
            [EnumMember(Value="account_wrong")]
            ACCOUNT_WRONG,
        }
        /// <summary>
        ///  移除类型，MANUAL-手动，SCHEDULE-策略, 目前只有手动
        /// </summary>
        public enum removeType
        {
            [EnumMember(Value="MANUAL")]
            MANUAL,
            [EnumMember(Value="SCHEDULE")]
            SCHEDULE,
        }
        /// <summary>
        ///  策略动作, ADD_IP_BLACK_LIST-添加IP黑名单，ADD_USER_BLACK_LIST-添加用户黑名单
        /// </summary>
        public enum action
        {
            [EnumMember(Value="ADD_IP_BLACK_LIST")]
            ADD_IP_BLACK_LIST,
            [EnumMember(Value="ADD_USER_BLACK_LIST")]
            ADD_USER_BLACK_LIST,
        }
        /// <summary>
        ///  限制类型列表,FORBID_LOGIN-禁止登录，FORBID_REGISTER-禁止注册
        /// </summary>
        public enum limitList
        {
            [EnumMember(Value="FORBID_LOGIN")]
            FORBID_LOGIN,
            [EnumMember(Value="FORBID_REGISTER")]
            FORBID_REGISTER,
        }
    }
}