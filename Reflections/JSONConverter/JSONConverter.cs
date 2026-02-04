using System.Reflection;
using System.Text;
namespace Reflections;

public class JSONConverter
{
    public static string ToJson(object obj)
    {
        StringBuilder json = new StringBuilder();
        json.Append("{\n");

        Type type = obj.GetType();
        FieldInfo[] fields = type.GetFields(
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        for(int i=0; i<fields.Length; i++)
        {
            string fieldName = fields[i].Name;
            object fieldValue = fields[i].GetValue(obj);

            json.Append("  \"")
                .Append(fieldName)
                .Append("\": ");

            if (fieldValue is string)
            {
                json.Append("\"").Append(fieldValue).Append("\"");
            }
            else
            {
                json.Append(fieldValue);
            }

            if (i < fields.Length - 1)
            {
                json.Append(",");
            } 

            json.Append("\n");
        }
        json.Append("}");
        return json.ToString();
    }
}
