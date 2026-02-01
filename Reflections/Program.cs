using System.Reflection;
namespace Reflections;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        // Get class type
        //Type type = typeof(GetClass);
        //Console.WriteLine("Class Name: " + type.Name);

        //// Fileds
        //Console.WriteLine("\nFileds: ");
        //foreach (FieldInfo f in type.GetFields())
        //{
        //    Console.WriteLine(f.Name);
        //}

        //// Constructors
        //Console.WriteLine("\nConstructors: ");
        //foreach (ConstructorInfo c in type.GetConstructors())
        //{
        //    Console.WriteLine(c.Name);
        //}

        //// Methods
        //Console.WriteLine("\nMethods: ");
        //foreach (MethodInfo m in type.GetMethods())
        //{
        //    Console.WriteLine(m.Name);
        //}


        // Problem 2
        //Person person = new Person();

        //Type type = typeof(Person);

        //FieldInfo f = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

        //f.SetValue(person, 22);3

        //int val = (int)f.GetValue(person);

        //Console.WriteLine("Age: " + val);


        // Problem 3
        Calculator calculator = new Calculator();

        Type type = typeof(Calculator);

        MethodInfo method = type.GetMethod("Multiply",
            BindingFlags.NonPublic | BindingFlags.Instance
        );

        object res = method.Invoke(calculator, new object[] { 54, 5 });

        Console.WriteLine("Result: " + res);

        Console.ReadKey();
    }
}
