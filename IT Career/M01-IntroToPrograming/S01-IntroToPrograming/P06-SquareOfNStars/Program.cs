public class Program
{
    public static void function(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write("*");
        }
    }
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        function(n);
        Console.WriteLine();
        for (int i = 2; i < n; i++)
        {
            Console.Write("*");
            for (int j = 1; j < n - 1; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("*");
        }
        function(n);
    }
}