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
    /// FilterDto 的模型
    /// </summary>
    public partial class FilterDto
    {
        /// <summary>
        ///  功能 id
        /// </summary>
        [JsonProperty("modelId")]
        public string  ModelId {get;set;}
        /// <summary>
        ///  关键字
        /// </summary>
        [JsonProperty("keywords")]
        public string  Keywords {get;set;}
        /// <summary>
        ///  多个搜索条件的关系：
/// - and: 且
/// - or:  或
/// 
        /// </summary>
        [JsonProperty("conjunction")]
        public string  Conjunction {get;set;}
        /// <summary>
        ///  搜索条件
        /// </summary>
        [JsonProperty("conditions")]
        public List<Condition>  Conditions {get;set;}
        /// <summary>
        ///  排序条件
        /// </summary>
        [JsonProperty("sort")]
        public List<object>  Sort {get;set;}
        /// <summary>
        ///  当前页数，从 1 开始
        /// </summary>
        [JsonProperty("page")]
        public long  Page {get;set;}
        /// <summary>
        ///  每页数目，最大不能超过 50，默认为 10
        /// </summary>
        [JsonProperty("limit")]
        public long  Limit {get;set;}
        /// <summary>
        ///  是否不分页返回所有（仅支持树形结构获取子节点的场景）
        /// </summary>
        [JsonProperty("fetchAll")]
        public bool  FetchAll {get;set;}
        /// <summary>
        ///  是否返回节点的全路径（仅支持树形结构）
        /// </summary>
        [JsonProperty("withPath")]
        public bool  WithPath {get;set;}
        /// <summary>
        ///  返回结果中是否使用字段 id 作为 key
        /// </summary>
        [JsonProperty("showFieldId")]
        public bool  ShowFieldId {get;set;}
        /// <summary>
        ///  返回结果中是包含关联数据的预览（前三个）
        /// </summary>
        [JsonProperty("previewRelation")]
        public bool  PreviewRelation {get;set;}
        /// <summary>
        ///  是否返回关联数据的详细用户信息，当前只支持用户。
        /// </summary>
        [JsonProperty("getRelationFieldDetail")]
        public bool  GetRelationFieldDetail {get;set;}
        /// <summary>
        ///  限定检索范围为被某个功能关联的部分
        /// </summary>
        [JsonProperty("scope")]
        public ScopeDto  Scope {get;set;}
        /// <summary>
        ///  过滤指定关联数据
        /// </summary>
        [JsonProperty("filterRelation")]
        public ScopeDto  FilterRelation {get;set;}
        /// <summary>
        ///  获取对应关联数据的详细字段
        /// </summary>
        [JsonProperty("expand")]
        public List<Expand>  Expand {get;set;}
    }
}