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
    /// GetUserPasswordCiphertextDataDto 的模型
    /// </summary>
    public partial class GetUserPasswordCiphertextDataDto
    {
        /// <summary>
        ///  用户密码加密的密文
        /// </summary>
        [JsonProperty("ciphertext")]
        public string  Ciphertext {get;set;}
    }
}