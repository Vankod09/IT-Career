public class Program
{
    public static void Main()
    {
        double rad = double.Parse(Console.ReadLine());
        double deg = rad * 180 / Math.PI;
        Console.WriteLine($"{deg:f0}");
    }
}