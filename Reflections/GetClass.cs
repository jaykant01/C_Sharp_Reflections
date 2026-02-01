namespace Reflections;

public class GetClass
{
    public int Id;
    public string Name;

    public GetClass(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine("Student details");
    }

}
