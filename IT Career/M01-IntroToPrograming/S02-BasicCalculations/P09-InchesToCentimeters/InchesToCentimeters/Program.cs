public class Program
{
    public static void Main(string[] args)
    {
        double inches = double.Parse(Console.ReadLine());
        double centimeters = 2.54 * inches;
        Console.WriteLine(centimeters);
    }
}