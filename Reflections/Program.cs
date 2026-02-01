using System.Reflection;
namespace Reflections;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        // Get class type
        Type type = typeof(GetClass);
        Console.WriteLine("Class Name: " + type.Name);

        // Fileds
        Console.WriteLine("\nFileds: ");
        foreach (FieldInfo f in type.GetFields())
        {
            Console.WriteLine(f.Name);
        }

        // Constructors
        Console.WriteLine("\nConstructors: ");
        foreach (ConstructorInfo c in type.GetConstructors())
        {
            Console.WriteLine(c.Name);
        }

        // Methods
        Console.WriteLine("\nMethods: ");
        foreach (MethodInfo m in type.GetMethods())
        {
            Console.WriteLine(m.Name);
        }



        Console.ReadKey();
    }
}
