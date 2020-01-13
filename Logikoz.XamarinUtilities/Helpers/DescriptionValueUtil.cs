using System.ComponentModel;
using System.Linq;

namespace Logikoz.XamarinUtilities.Utilities
{
    public class DescriptionValueUtil
    {
        public static string Get<T>(T type)
        {
            object[] valueAttributes = type.GetType().GetMember(type.ToString())
                .FirstOrDefault(i => i.DeclaringType == type.GetType()).GetCustomAttributes(typeof(DescriptionAttribute), false);

            return valueAttributes.Length > 0 ? ((DescriptionAttribute)valueAttributes[0]).Description : string.Empty;
        }
    }
}