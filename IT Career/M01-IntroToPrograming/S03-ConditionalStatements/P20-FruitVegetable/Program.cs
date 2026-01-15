public class Program
{
    public static void Main()
    {
        string fruit = Console.ReadLine();
        if (fruit == "apple" || fruit == "banana" || fruit == "kiwi" || fruit == "cherry" || fruit == "lemon" || fruit == "grapes")
        {
            Console.WriteLine("fruit");
        }
        else if (fruit == "tomato" || fruit == "cucumber" || fruit == "pepper" || fruit == "carrot")
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}