public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int maxdiff = 0;
        bool isdifferent = false;

        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int previousSum = n1 + n2;
        
        for (int i = 1; i < n; i++)
        {
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            int currentSum = n1 + n2;
            if (currentSum != previousSum)
            {
                isdifferent = true;
                int currentdiff = Math.Abs(currentSum - previousSum);
                if (currentdiff > maxdiff)
                {
                    maxdiff = currentdiff;
                }
            }

            previousSum = currentSum;

        }
        if (isdifferent)
        {
            Console.WriteLine($"No, maxdiff = {maxdiff}");
        }
        else
        {
            Console.WriteLine($"Yes, value = {previousSum}");
        }
    }
}