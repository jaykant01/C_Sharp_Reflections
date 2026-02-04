using System.Threading;
namespace Reflections;

public class TestClass
{
    public void Method1()
    {
        Thread.Sleep(500); 
        Console.WriteLine("Method1 Executed");
    }

    public void Method2()
    {
        Thread.Sleep(1000); 
        Console.WriteLine("Method2 Executed");
    }
}
