public class Program
{
    public static void Main()
    {
        string figure = Console.ReadLine();
        switch (figure)
        {
            case "square":
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(a * a);
                break;
            case "rectangle":
                double a2 = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(a2 * b);
                break;
            case "circle":
                double p = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI * p * p:f3}");
                break;
            case "triangle":
                double a3 = double.Parse(Console.ReadLine());
                double b2 = double.Parse(Console.ReadLine());
                Console.WriteLine((a3 * b2) / 2);
                break;
            default:
                Environment.Exit(0);
                break;
        }
    }
}