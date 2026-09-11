namespace simpleGit;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello Git!");
        Console.WriteLine(DoSomething("Bhuvana"));
    }

    static string DoSomething(string name)
    {
        return $"Hello {name}";
    }
}
