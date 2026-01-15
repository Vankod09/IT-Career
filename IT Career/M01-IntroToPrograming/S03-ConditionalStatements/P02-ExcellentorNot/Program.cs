public class Program
{
    static void Main()
    {
        double mark = double.Parse(Console.ReadLine());
        if (mark >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not Excellent.");
        }
    }
}