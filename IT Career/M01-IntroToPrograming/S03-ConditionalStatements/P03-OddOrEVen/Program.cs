public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        bool IsTrue = num % 2 == 0;
        if (IsTrue)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}