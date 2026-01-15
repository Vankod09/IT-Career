public class Program
{
    public static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int a = n1 + n2;
        int b = n3 + a;
        if (a >= 60)
        {
            int minutes = a / 60;
            int seconds = a % 60;
            b = n3 + seconds;
            if (b >= 60)
            {
                minutes += b / 60;
                b = b % 60;
            }
            Console.WriteLine($"{minutes}:{b:D2}");
        }
        else
        {
            if (b >= 60)
            {
                int minutes = b / 60;
                int seconds = b % 60;
                Console.WriteLine($"{minutes}:{seconds:D2}");
            }
            else
            {
                Console.WriteLine($"0:{b:D2}");
            }
        }
    }
}