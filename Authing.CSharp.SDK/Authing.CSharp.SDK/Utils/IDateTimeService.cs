using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Utils
{
    public interface IDateTimeService
    {
        /// <summary>
        /// 本时区日期时间转 Unix 时间戳
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns>long=Int64</returns>
        long DateTimeToTimestamp(DateTime datetime);
    }
}
