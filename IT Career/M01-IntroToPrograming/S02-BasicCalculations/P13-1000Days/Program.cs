public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();

        DateTime date = DateTime.ParseExact(input, "dd-MM-yyyy", null);

        date = date.AddDays(999);
        Console.WriteLine(date.ToString("dd-MM-yyyy"));
    }
}