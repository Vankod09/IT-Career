using System.ComponentModel.DataAnnotations;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        int a = 0;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            a = int.Parse(Console.ReadLine());
            sum+= a;

            if (a > max) max = a;
        }
        if (max == sum - max)
        {
            Console.WriteLine($"Yes Sum = {max}");
        }
        else
        {
            Console.WriteLine($"No Diff = {Math.Abs(max - (sum - max))}");
        }
    }
}