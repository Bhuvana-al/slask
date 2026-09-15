namespace simpleGit;

public class Account
{
    public int Balance { get; set; }

    public string AccountNumber { get; set; } = "";

    public void Deposit (int amount)
    {
        Console.WriteLine ("Deposit");
        Console.WriteLine("Michael jobbade med detta");
        Console.WriteLine("Bhuvana jobbade med detta");
    }
}
