using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Models
{
    public class BizResult
    {
        public bool Success { get; protected set; }
        public string Code { get; set; }
        public string Message { get; set; }

        public string ErrorCode { get; set; }

        protected BizResult()
        { }

        public void EnsureSuccess()
        {
            if (!Success)
            {
                if (string.IsNullOrWhiteSpace(Message))
                {
                    throw new Exception("未知错误");
                }
                else
                {
                    throw new Exception(Message);
                }
            }
        }

        public static BizResult Ok()
        {
            return new BizResult()
            {
                Success = true,
                Message = string.Empty,
                ErrorCode = string.Empty,
                Code = string.Empty
            };
        }

        public static BizResult<TData> OK<TData>(TData data)
        {
            return new BizResult<TData>()
            {
                Success = true,
                Message = string.Empty,
                Data = data,
                ErrorCode = string.Empty
            };
        }

        public static BizResult Error(string errorCode, Exception exception)
        {
            return new BizResult()
            {
                Success = false,
                Message = exception.Message,
                ErrorCode = errorCode
            };
        }

        public static BizResult<TData> Error<TData>(string errorCode, Exception exception)
        {
            return new BizResult<TData>()
            {
                Success = false,
                Message = exception.Message,
                Data = default,
                ErrorCode = errorCode
            };
        }
    }

    public class BizResult<T> : BizResult
    {
        public T Data { get; set; }
    }
}
