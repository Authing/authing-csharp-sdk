using Authing.CSharp.SDK.Infrastructure;
using Authing.CSharp.SDK.IServices;
using Authing.CSharp.SDK.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Services
{
    public abstract class ServiceBase
    {
        protected readonly IJsonService m_JsonService;
        protected readonly IHttpService m_HttpService;
        protected readonly IDateTimeService m_DateTimeService;

        protected string m_AccessToken;
        protected long? TokenExpirAt;

        public ServiceBase(IJsonService jsonService,IDateTimeService dateTimeService)
        {
            m_JsonService = jsonService;
            m_DateTimeService = dateTimeService;

            m_HttpService = HttpServiceFactory.Get(m_JsonService, Enums.HttpServiceType.HTTPWEBREQUEST, m_DateTimeService);

        }

        protected string BuildHttpPostRequest(Dictionary<string, string> @params)
        {
            return BuildHttpPostRequest<Dictionary<string, string>>(@params);
        }

        protected string BuildHttpPostRequest<T>(T obj)
        {
            return m_JsonService.SerializeObject(obj);
        }



    }
}
