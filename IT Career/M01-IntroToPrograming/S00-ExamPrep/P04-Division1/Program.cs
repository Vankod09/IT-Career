public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p1 = 0; int p2 = 0; int p3 = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                p1++;
            }
            if (number % 3 == 0)
            {
                p2++;
            }
            if (number % 5 == 0)
            {
                p3++;
            }
        }
        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
    }
}