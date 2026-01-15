public class Program
{
    static void Main()
    {
        byte hours = byte.Parse(Console.ReadLine());
        byte minutes = byte.Parse(Console.ReadLine());

        minutes += 15;

        if (minutes >= 60)
        {
            minutes -= 60;
            hours++;
            if (hours > 23)
            {
                hours -= 24;
            }
        }
        if (minutes < 10)
        {
            Console.WriteLine($"{hours}:0{minutes}");
        }
        else
        {
            Console.WriteLine($"{hours}:{minutes}");
        }
    }
}