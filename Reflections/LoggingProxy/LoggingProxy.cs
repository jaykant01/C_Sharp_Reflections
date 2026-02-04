using System.Reflection;
namespace Reflections;

public class LoggingProxy
{
    private object target;

    public LoggingProxy(object obj)
    {
        target = obj;
    }

    public void CallMethod(string methodName, object[] parameters)
    {
        Console.WriteLine("[LOG] Calling Method: " + methodName);

        // Get method info using Reflection
        MethodInfo method = target.GetType().GetMethod(methodName);

        // Execute method
        method.Invoke(target, parameters);
    }
}
