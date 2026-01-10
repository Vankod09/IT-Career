public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string Destination = Console.ReadLine();
        string RoomType = Console.ReadLine();
        double TotalPrice = 0;

        if (RoomType == "double")
        {
            switch (Destination)
            {
                case "Sofia": TotalPrice = n * 38; break;
                case "Plovdiv": TotalPrice = n * 35; break;
                case "Varna": TotalPrice = n * 39; break;
            }
        }
        else if (RoomType == "apartment")
        {
            switch (Destination)
            {
                case "Sofia": TotalPrice = n * 45; break;
                case "Plovdiv": TotalPrice = n * 42; break;
                case "Varna": TotalPrice = n * 49; break;
            }
        }
        if (n > 10)
        {
            TotalPrice = TotalPrice * 0.85;
        }
        Console.WriteLine($"They have to spend {TotalPrice:F2} leva.");
    }
}