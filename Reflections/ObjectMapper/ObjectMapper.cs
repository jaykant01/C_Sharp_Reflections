using System.Collections.Generic;
using System.Reflection;
namespace Reflections;

public class ObjectMapper
{
    public static T ToObject<T>(Type clazz, Dictionary<string, object> properties)
    {
        // Create object of given class
        object obj = Activator.CreateInstance(clazz);

        foreach (var item in properties)
        {
            FieldInfo field = clazz.GetField(item.Key);

            if (field != null)
            {
                field.SetValue(obj, item.Value);
            }
        }
        return (T)obj;
    }
}
