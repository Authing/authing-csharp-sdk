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
    /// SendResetPasswordNotificationDto 的模型
    /// </summary>
    public partial class SendResetPasswordNotificationDto
    {
        /// <summary>
        ///  重置密码之后，是否发送用户默认邮件通知
        /// </summary>
        [JsonProperty("sendDefaultEmailNotification")]
        public bool  SendDefaultEmailNotification  {get;set;}
        /// <summary>
        ///  重置密码之后，是否发送用户默认短信通知
        /// </summary>
        [JsonProperty("sendDefaultPhoneNotification")]
        public bool  SendDefaultPhoneNotification  {get;set;}
        /// <summary>
        ///  当用户密码修改之后，输入发送邮箱
        /// </summary>
        [JsonProperty("inputSendEmailNotification")]
        public string  InputSendEmailNotification  {get;set;}
        /// <summary>
        ///  当用户密码修改之后，输入发送手机号
        /// </summary>
        [JsonProperty("inputSendPhoneNotification")]
        public string  InputSendPhoneNotification  {get;set;}
        /// <summary>
        ///  发送登录地址时，指定的应用 id，会将此应用的登录地址发送给用户的邮箱或者手机号。默认为用户池应用面板的登录地址。
        /// </summary>
        [JsonProperty("appId")]
        public string  AppId  {get;set;}
    }
}