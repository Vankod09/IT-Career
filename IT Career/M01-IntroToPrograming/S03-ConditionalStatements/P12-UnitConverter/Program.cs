using System;

class Program
{
    static void Main()
    {
        double value = double.Parse(Console.ReadLine());
        string from = Console.ReadLine();
        string to = Console.ReadLine();

        double meters = 0;

        // convert input to meters
        if (from == "m") meters = value;
        else if (from == "mm") meters = value / 1000;
        else if (from == "cm") meters = value / 100;
        else if (from == "mi") meters = value / 0.000621371192;
        else if (from == "in") meters = value / 39.3700787;
        else if (from == "km") meters = value / 0.001;
        else if (from == "ft") meters = value / 3.2808398950131;
        else if (from == "yd") meters = value / 1.0936133;

        double result = 0;

        // convert meters to target unit
        if (to == "m") result = meters;
        else if (to == "mm") result = meters * 1000;
        else if (to == "cm") result = meters * 100;
        else if (to == "mi") result = meters * 0.000621371192;
        else if (to == "in") result = meters * 39.3700787;
        else if (to == "km") result = meters * 0.001;
        else if (to == "ft") result = meters * 3.2808399;
        else if (to == "yd") result = meters * 1.0936133;

        Console.WriteLine(result + " " + to);
    }
}
