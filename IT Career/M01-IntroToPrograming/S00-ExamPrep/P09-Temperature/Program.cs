public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p1 = 0; int p2 = 0; int p3 = 0; int p4 = 0; int p5 = 0;

        for (int i = 0; i < n; i++)
        {
            double Temperature = double.Parse(Console.ReadLine());

            if (Temperature < -30)
            {
                p1++;
            }
            else if (Temperature >= -30 && Temperature < 5)
            {
                p2++;
            }
            else if (Temperature >= 5 && Temperature < 25)
            {
                p3++;
            }
            else if (Temperature >= 25 && Temperature < 65)
            {
                p4++;
            }
            else if (Temperature >= 65)
            {
                p5++;
            }
        }
        Console.WriteLine($"Icy: {(p1 * 100.0) / n}%");
        Console.WriteLine($"Cold: {(p2 * 100.0) / n}%");
        Console.WriteLine($"Cool: {(p3 * 100.0) / n}%");
        Console.WriteLine($"Warm: {(p4 * 100.0) / n}%");
        Console.WriteLine($"Hot: {(p5 * 100.0) / n}%");
    }
}