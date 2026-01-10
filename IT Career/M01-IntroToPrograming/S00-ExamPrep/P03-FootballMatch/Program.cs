public class Program
{
    public static void Main()
    {
        string Sector = Console.ReadLine();
        int Rows = int.Parse(Console.ReadLine());
        int SeatsPerRow = int.Parse(Console.ReadLine());
        double price = 0;

        if (Sector == "Sector A")
        {
            price = 11.60 * Rows * SeatsPerRow;
            Console.WriteLine($"{Sector} profit is {price:F2} lv.");
        }
        else if (Sector == "Sector B")
        {
            price = 14.50 * Rows * SeatsPerRow;
            Console.WriteLine($"{Sector} profit is {price:F2} lv.");
        }
        else if (Sector == "Sector C")
        {
            price = 16.10 * Rows * SeatsPerRow;
            Console.WriteLine($"{Sector} profit is {price:F2} lv.");
        }
        else
        {
            price = 8.40 * Rows * SeatsPerRow;
            Console.WriteLine($"{Sector} profit is {price:F2} lv.");
        }
    }
}