namespace Reflections;

public class Greeting : IGreeting
{
    public void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}
