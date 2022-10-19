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
/// GetFactorDto 的模型
/// </summary>
public partial class GetFactorDto
{
    /// <summary>
    ///  MFA Factor ID
    /// </summary>
    [JsonProperty("factorId")]
    public string  FactorId {get;set;} 
}
}