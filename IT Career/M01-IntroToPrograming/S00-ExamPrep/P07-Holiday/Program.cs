public class Program
{
    public static void Main()
    {
        double GlassesPrice = double.Parse(Console.ReadLine());
        int GlassesCount = int.Parse(Console.ReadLine());
        int TowelCount = int.Parse(Console.ReadLine());
        int SunscreenCount = int.Parse(Console.ReadLine());
        int UmbrellaCount = int.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());

        double TowelPrice = GlassesPrice * 1.20;
        double SunscreenPrice = TowelPrice * 0.60;
        double UmbrellaPrice = SunscreenPrice + 1.20;
        double TotalPrice = (GlassesPrice * GlassesCount) +
                            (TowelPrice * TowelCount) +
                            (SunscreenPrice * SunscreenCount) +
                            (UmbrellaPrice * UmbrellaCount);

        if (budget >= TotalPrice)
        {
            Console.WriteLine($"Yes! {budget - TotalPrice:F2} leva left.");
        }
        else
        {
            Console.WriteLine($"No! {TotalPrice - budget:f2} leva needed.");
        }
    }
}