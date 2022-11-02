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
    /// SendCreateAccountNotificationDto 的模型
    /// </summary>
    public partial class SendCreateAccountNotificationDto
    {
        /// <summary>
        ///  创建账号之后，是否发送邮件通知
        /// </summary>
        [JsonProperty("sendEmailNotification")]
        public bool  SendEmailNotification {get;set;}
        /// <summary>
        ///  创建账号之后，是否发送短信通知
        /// </summary>
        [JsonProperty("sendPhoneNotification")]
        public bool  SendPhoneNotification {get;set;}
        /// <summary>
        ///  发送登录地址时，指定的应用 id，会将此应用的登录地址发送给用户的邮箱或者手机号。默认为用户池应用面板的登录地址。
        /// </summary>
        [JsonProperty("appId")]
        public string  AppId {get;set;}
    }
}