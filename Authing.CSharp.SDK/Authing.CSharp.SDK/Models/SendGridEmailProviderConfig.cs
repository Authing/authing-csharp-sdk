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
    /// SendGridEmailProviderConfig 的模型
    /// </summary>
    public partial class SendGridEmailProviderConfig
    {
        /// <summary>
        ///  用户名
        /// </summary>
        [JsonProperty("sender")]
        public string  Sender  {get;set;}
        /// <summary>
        ///  SendGrid API Key，详情请见 [SendGrid 文档](https://docs.sendgrid.com/ui/account-and-settings/api-keys)。
        /// </summary>
        [JsonProperty("apikey")]
        public string  Apikey  {get;set;}
    }
}