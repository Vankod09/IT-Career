public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string b = string.Empty;
        bool isTrue = true;

        string c = $"{new string('+', 1)}{new string(' ', 1)}{new string('-', n - 2)}{new string(' ', 1)}{new string('+', 1)}";

        if (n == 2)
        {
            isTrue = false;
            Console.WriteLine(c);
            Console.WriteLine(c);
        }

        if (isTrue == true)
        {

            string a = $"{new string('+', 1)}{new string('-', n - 2)}{new string('+', 1)}";
        Console.WriteLine(a);

        
            for (int i = 0; i < n - 2; i++)
            {
                b = $"{new string('|', 1)}{new string('-', n - 2)}{new string('|', 1)}";

                Console.WriteLine(b);
            }

            Console.WriteLine(a);
        }
    }
}