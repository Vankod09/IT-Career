public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter two integers:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        bool IsTrue = num1 > num2;
        if (IsTrue)
        {
            Console.WriteLine(num1);
        }
        else
        {
            Console.WriteLine(num2);
        }
    }
}