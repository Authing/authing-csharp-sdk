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
    /// ImportTenantDto 的模型
    /// </summary>
    public partial class ImportTenantDto
    {
        /// <summary>
        ///  excel path 地址
        /// </summary>
        [JsonProperty("excelUrl")]
        public string  ExcelUrl  {get;set;}
    }
}