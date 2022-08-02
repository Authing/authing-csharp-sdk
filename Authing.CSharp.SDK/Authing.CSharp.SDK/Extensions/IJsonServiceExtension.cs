using Authing.CSharp.SDK.IServices;
using Authing.CSharp.SDK.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Extensions
{
    static class IJsonServiceExtension
    {
        public static BizResult Resultify(this IJsonService jsonService, string json)
        {
            ResponseResult result = jsonService.DeserializeObject<ResponseResult>(json);
            if (result.OK)
            {
                return BizResult.Ok();
            }
            return BizResult.Error(result.Code.ToString(), new Exception(result.Message));
        }

        public static BizResult<T> Resultify<T>(this IJsonService jsonService, string json)
        {
            ResponseResult result = jsonService.DeserializeObject<ResponseResult>(json);
            if (result.OK)
            {
                ResponseResult<T> responseResult = jsonService.DeserializeObject<ResponseResult<T>>(json);
                return BizResult.OK(responseResult.Data);
            }
            return BizResult.Error<T>(result.Code.ToString(), new Exception(result.Message));
        }
    }

    class ResponseResult
    {
        [JsonProperty("code")]
        public long Code { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("errorCode")]
        public long ErrorCode { get; set; }

        public bool OK => Code == 200;
    }

    class ResponseResult<T> : ResponseResult
    {
        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
