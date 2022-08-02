using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Utils
{
    public interface IDateTimeService
    {
       long DateTimeToLongTimeStamp(DateTime dateTime);
    }
}
