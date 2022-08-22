using Authing.CSharp.SDK.Enums;
using Authing.CSharp.SDK.IServices;
using Authing.CSharp.SDK.Utils;
using Authing.CSharp.SDK.UtilsImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Infrastructure
{
    public static class HttpServiceFactory
    {
        public static IHttpService Get(IJsonService jsonService, HttpServiceType httpService)
        {
            switch (httpService)
            {
                case HttpServiceType.HTTPWEBREQUEST: return new HttpWebService(jsonService);

#if NETSTANDARD2_0_OR_GREATER
                case HttpServiceType.HTTPCLIENT:return new HttpClienService(jsonService);
#endif
            }
            return new HttpWebService(jsonService);
        }
    }
}
