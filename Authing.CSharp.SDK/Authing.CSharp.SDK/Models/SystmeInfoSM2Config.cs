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
/// SystmeInfoSM2Config 的模型
/// </summary>
public partial class SystmeInfoSM2Config
{
    /// <summary>
    ///  SM2 公钥
    /// </summary>
    [JsonProperty("publicKey")]
    public string  PublicKey {get;set;}
}
}