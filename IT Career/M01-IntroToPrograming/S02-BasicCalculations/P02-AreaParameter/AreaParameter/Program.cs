public class Program
{
    public static void Main(string[] args)
    {
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * r * r;
        double parameter = r * Math.PI * 2;
        Console.WriteLine($"Area = {area:f2}");
        Console.WriteLine($"Parameter = {parameter:f2}");
    }
}