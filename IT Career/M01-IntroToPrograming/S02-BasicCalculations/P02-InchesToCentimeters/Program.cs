public class Program
{
    public static void Main()
    {
        double inches = double.Parse(Console.ReadLine());
        double centimeters = 2.54 * inches;
        Console.WriteLine(centimeters);
    }
}