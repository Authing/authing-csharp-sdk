using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Authing.CSharp.SDK.Utils.Extensions
{
    internal static class EnumExtension
    {
        public static string GetDescription(this Enum value, bool nameInstead = true)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name == null)
            {
                return null;
            }

            FieldInfo field = type.GetField(name);
            DescriptionAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

            if (attribute == null && nameInstead)
            {
                return name;
            }

            return attribute == null ? null : attribute.Description;
        }
    }
}
