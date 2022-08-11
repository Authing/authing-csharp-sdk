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
            if (reader.ValueType == typeof(string))
            {
                if (reader.Value != null)
                {
                    if (reader.Value.ToString() == trueValue || reader.Value.ToString() == falseValue)
                    {
                        return reader.Value.ToString() == trueValue;
                    }
                    if (objectType == typeof(bool))
                    {
                        //文档定义值为 bool，但是传过来的 json 值为 字符串
                        return reader.Value.ToString() == trueValue;
                    }
                }
            }
            else if (reader.ValueType == typeof(bool))
            {
                if (reader.Value != null)
                {
                    if (reader.Value.ToString() == "True" || reader.Value.ToString() == "False")
                    {
                        return reader.Value.ToString() == "True";
                    }
                    else if (string.IsNullOrEmpty(reader.Value.ToString()))
                    {
                        return false;
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
