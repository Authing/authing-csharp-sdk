using Authing.CSharp.SDK.Infrastructure;
using Authing.CSharp.SDK.IServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Utils
{
    public class JsonService : IJsonService
    {
        private JsonSerializerSettings settings;

        private List<JsonConverter> converters;

        private BooleanStringJsonConverter booleanStringJsonConverter;
        private StringEnumConverter stringEnumConverter;
        public JsonService()
        {
            booleanStringJsonConverter = new BooleanStringJsonConverter();
            stringEnumConverter = new StringEnumConverter();

            converters = new List<JsonConverter>();
            converters.Add(new BooleanStringJsonConverter());

            settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                Converters = converters,
                ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()
            };
        }

        public string SerializeObject(object obj)
        {
            string result = JsonConvert.SerializeObject(obj, stringEnumConverter);
            return result;
        }

        public string SerializeObjectCamelCase(object obj,bool ingoreNull=true)
        {
            settings = new JsonSerializerSettings
            {
                NullValueHandling=ingoreNull? NullValueHandling.Ignore:NullValueHandling.Include,
                ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver(),
                Converters = new List<JsonConverter>() 
                {
                    new StringEnumConverter()
                }
            };

            string result = JsonConvert.SerializeObject(obj, settings);
            return result;
        }

        public T DeserializeObject<T>(string jsonStr)
        {
            T obj = JsonConvert.DeserializeObject<T>(jsonStr, settings);
            return obj;
        }
    }
}
