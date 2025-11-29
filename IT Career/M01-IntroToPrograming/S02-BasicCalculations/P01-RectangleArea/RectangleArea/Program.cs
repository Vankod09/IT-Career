public class Program
{
    public static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double a = Math.Abs(y1 - y2);
        double b = Math.Abs(x1 - x2);
        Console.WriteLine(a * b);
        Console.WriteLine(2 * (a + b));
    }
}