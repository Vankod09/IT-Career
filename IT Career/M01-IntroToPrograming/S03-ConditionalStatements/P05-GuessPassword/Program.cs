public class Program
{
    private static string Pass = "s3cr3t!P@ssw0rd";
    public static void Main()
    {
        string password = Console.ReadLine();
        if (password == Pass)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}