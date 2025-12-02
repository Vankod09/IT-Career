public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int evensum = 0;
        int oddsum = 0;

        for (int i = 1; i <= n; i++)
        {
            int a = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                evensum += a;
            }
            else
            {
                oddsum += a;
            }
        }
        if (evensum == oddsum)
        {
            Console.WriteLine($"Yes Sum = {evensum}");
        }
        else if (evensum != oddsum)
        {
            Console.WriteLine($"No Diff = {Math.Abs(evensum - oddsum)}");
        }
    }
}