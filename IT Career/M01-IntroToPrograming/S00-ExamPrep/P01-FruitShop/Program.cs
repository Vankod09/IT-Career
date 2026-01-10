public class Program
{
    public static void Main()
    {
        double strawberryPrice = double.Parse(Console.ReadLine());
        double bananaKg = double.Parse(Console.ReadLine());
        double orangeKg = double.Parse(Console.ReadLine());
        double raspberryKg = double.Parse(Console.ReadLine());
        double strawberryKg = double.Parse(Console.ReadLine());

        double raspberryPrice = strawberryPrice / 2;
        double orangePrice = raspberryPrice * 0.6;
        double bananaPrice = raspberryPrice * 0.2;
        double totalPrice = (bananaKg * bananaPrice) +
                            (strawberryKg * strawberryPrice) +
                            (orangeKg * orangePrice) +
                            (raspberryKg * raspberryPrice);

        Console.WriteLine(totalPrice);
    }
}