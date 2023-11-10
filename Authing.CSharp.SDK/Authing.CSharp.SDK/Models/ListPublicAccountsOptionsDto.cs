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
    /// ListPublicAccountsOptionsDto 的模型
    /// </summary>
    public partial class ListPublicAccountsOptionsDto
    {
        /// <summary>
        ///  分页配置
        /// </summary>
        [JsonProperty("pagination")]
        public PaginationDto  Pagination {get;set;}
        /// <summary>
        ///  排序设置，可以设置多项按照多个字段进行排序
        /// </summary>
        [JsonProperty("sort")]
        public List<SortingDto>  Sort {get;set;}
        /// <summary>
        ///  模糊搜索匹配的公共账号字段，可选值为：
/// - `phone`: 公共账号手机号，不能包含手机号区号，默认包含
/// - `email`: 公共账号邮箱，默认包含
/// - `name`: 公共账号名称，默认包含
/// - `username`: 用户名，默认包含
/// - `nickname`: 公共账号昵称，默认包含
/// - `id`: 公共账号 ID
/// - `company`: 公司
/// - `givenName`: 名
/// - `familyName`: 姓
/// - `middleName`: 中间名
/// - `preferredUsername`: Preferred Username
/// - `profile`: 个人资料
/// - `website`: 个人网站
/// - `address`: 地址
/// - `formatted`: 格式化地址
/// - `streetAddress`: 街道地址
/// - `postalCode`: 邮编号码
/// 
        /// </summary>
        [JsonProperty("fuzzySearchOn")]
        public List<string>  FuzzySearchOn {get;set;}
        /// <summary>
        ///  是否获取自定义数据
        /// </summary>
        [JsonProperty("withCustomData")]
        public bool  WithCustomData {get;set;}
        /// <summary>
        ///  是否获取部门 ID 列表
        /// </summary>
        [JsonProperty("withDepartmentIds")]
        public bool  WithDepartmentIds {get;set;}
    }
}