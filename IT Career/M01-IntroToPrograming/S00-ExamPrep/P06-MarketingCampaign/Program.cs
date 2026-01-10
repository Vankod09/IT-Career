public class Program
{
    public static void Main()
    {
        int AdPrice = int.Parse(Console.ReadLine());
        double BillboardPrice = AdPrice * 2;
        double MediaPrice = BillboardPrice * 0.85;
        double MaterialPrice = (MediaPrice + BillboardPrice) / 7;
        double TotalPrice = AdPrice + BillboardPrice + MediaPrice + MaterialPrice;

        Console.WriteLine($"{TotalPrice:F2}");
    }
}