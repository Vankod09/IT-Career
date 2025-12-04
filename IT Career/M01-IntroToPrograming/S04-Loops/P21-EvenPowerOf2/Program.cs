public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num = 1;
        Console.WriteLine(num);

        for (int i = 1; i <= n / 2; i++)
        {
            num = num * 4;
            Console.WriteLine(num);
        }
    }
}