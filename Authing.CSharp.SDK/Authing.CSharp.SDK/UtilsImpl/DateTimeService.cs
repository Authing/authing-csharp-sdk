using Authing.CSharp.SDK.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.UtilsImpl
{
    public class DateTimeService : IDateTimeService
    {

        public long DateTimeNowToTimestamp( )
        {
            long epochTicks = new DateTime(1970, 1, 1).Ticks;
            long unixTime = ((DateTime.UtcNow.Ticks - epochTicks) / TimeSpan.TicksPerMillisecond);

            return unixTime;
        }

        public long DatetimeToUnixTimeMilllisecond(DateTime dateTime)
        {
            long unixTime = (dateTime.ToUniversalTime().Ticks - 621355968000000000) / 10000;
            return unixTime;
        }
    }
}
