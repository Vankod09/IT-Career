public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string TopAndBottom = $"{new string('*', n * 2)}{new string(' ', n)}{new string('*', n * 2)}";
        Console.WriteLine(TopAndBottom);

        for (int i = 1; i <= n - 2; i++)
        {
            string left =
                $"{new string('*', 1)}" +
                $"{new string('/', (n * 2) - 2)}" +
                $"{new string('*', 1)}";

            string middle;
            if (i == (n - 1) / 2)
            {
                middle = new string('|', n);
            }
            else
            {
                middle = new string(' ', n);
            }


            string right =
            $"{new string('*', 1)}" +
            $"{new string('/', (n * 2) - 2)}" +
            $"{new string('*', 1)}";

            Console.WriteLine(left + middle + right);
        }
        Console.WriteLine(TopAndBottom);
    }
}