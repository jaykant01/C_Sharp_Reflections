using System.Diagnostics;
using System.Reflection;
namespace Reflections;

public class MethodTimer
{
    public static void MeasureExecutionTime(object obj)
    {
        Type type = obj.GetType();

        MethodInfo[] methods = type.GetMethods(
            BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly
        );

        foreach (MethodInfo method in methods)
        {
            Console.WriteLine("\nCalling Method: " + method.Name);

            Stopwatch sw = Stopwatch.StartNew();

            method.Invoke(obj, null);

            sw.Stop();

            Console.WriteLine("Execution Time: " + sw.ElapsedMilliseconds + " ms");
        }
    }
}
