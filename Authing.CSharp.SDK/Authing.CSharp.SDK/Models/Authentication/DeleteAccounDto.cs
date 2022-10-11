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
    /// DeleteAccounDto 的模型
    /// </summary>
    public partial class DeleteAccounDto
    {
        /// <summary>
        ///  注销账户的 token
        /// </summary>
        [JsonProperty("deleteAccountToken")]
        public    string   DeleteAccountToken    {get;set;}
    }
}