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
    /// DepartmentSortingDto 的模型
    /// </summary>
    public partial class DepartmentSortingDto
    {
        /// <summary>
        ///  进行排序的字段，可选值为：
/// - `updatedAt`: 创建时间
/// - `createdAt`: 修改时间
/// - `name`: 邮箱
/// 
        /// </summary>
        [JsonProperty("field")]
        public field  Field {get;set;}
        /// <summary>
        ///  排序顺序：
/// - `desc`: 按照从大到小降序。
/// - `asc`: 按照从小到大升序。
/// 
        /// </summary>
        [JsonProperty("order")]
        public order  Order {get;set;}
    }
    public partial class DepartmentSortingDto
    {
        /// <summary>
        ///  进行排序的字段，可选值为：
/// - `updatedAt`: 创建时间
/// - `createdAt`: 修改时间
/// - `name`: 邮箱
/// 
        /// </summary>
        public enum field
        {
            [EnumMember(Value="updatedAt")]
            UPDATED_AT,
            [EnumMember(Value="createdAt")]
            CREATED_AT,
            [EnumMember(Value="name")]
            NAME,
        }
        /// <summary>
        ///  排序顺序：
/// - `desc`: 按照从大到小降序。
/// - `asc`: 按照从小到大升序。
/// 
        /// </summary>
        public enum order
        {
            [EnumMember(Value="desc")]
            DESC,
            [EnumMember(Value="asc")]
            ASC,
        }
    }
}