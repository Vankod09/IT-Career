public class Program
{
    public static void Main()
    {
        double celcius = double.Parse(Console.ReadLine());
        double farenheit = celcius * 1.8 + 32;
        Console.WriteLine(farenheit);
    }
}