using Authing.CSharp.SDK.Enums;
using Authing.CSharp.SDK.IServices;
using Authing.CSharp.SDK.Utils;
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

            }
            return new HttpWebService(jsonService);
        }
    }
}
