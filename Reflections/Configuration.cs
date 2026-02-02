namespace Reflections;

public class Configuration
{
    private static string API_KEY = "DEFAULT_KEY";

    public static void PrintKey()
    {
        Console.WriteLine($"API Key: {API_KEY}");
    }
}
