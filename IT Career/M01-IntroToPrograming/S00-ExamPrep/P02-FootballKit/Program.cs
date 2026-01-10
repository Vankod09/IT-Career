public class Program
{
    public static void Main()
    {
        double TShirtPrice = double.Parse(Console.ReadLine());
        double ReachedPrice = double.Parse(Console.ReadLine());

        double ShortsPrice = TShirtPrice * 0.75;
        double SocksPrice = ShortsPrice * 0.20;
        double ShoesPrice = (TShirtPrice + ShortsPrice) * 2;
        double TotalPrice = TShirtPrice + ShortsPrice + SocksPrice + ShoesPrice;
        double FinalPrice = TotalPrice * 0.85;

        if (FinalPrice >= ReachedPrice)
        {
            Console.WriteLine("Yes, he will earn the world-cup replica ball!");
            Console.WriteLine($"His sum is {FinalPrice}lv.");
        }
        else
        {
            Console.WriteLine("No, he will not earn the world-cup replica ball.");
            Console.WriteLine($"He needs {(ReachedPrice - FinalPrice):f2}lv. more.");
        }
    }
}