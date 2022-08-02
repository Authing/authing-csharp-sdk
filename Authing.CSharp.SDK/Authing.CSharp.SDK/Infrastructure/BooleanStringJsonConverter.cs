using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Infrastructure
{
    public class BooleanStringJsonConverter : JsonConverter<bool>
    {
        private string trueValue = "enabled";
        private string falseValue = "disabled";

        public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.ValueType==typeof(string))
            {
                if (reader.Value!=null)
                {
                    if (reader.Value.ToString() == trueValue || reader.Value.ToString() == falseValue)
                    {
                        return reader.Value.ToString() == trueValue;
                    }
                }
            }

            return Convert.ToBoolean(reader.ValueType == typeof(string) ? Convert.ToByte(reader.Value) : reader.Value);
        }

        public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
