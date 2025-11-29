using System;

public class Program
{
    public static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        string unitFrom1 = Console.ReadLine();
        string unitForm2 = Console.ReadLine();
        double result = 0;

        switch (unitFrom1)
        {
            case "m":
                if (unitForm2 == "m") result = number;
                else if (unitForm2 == "cm") result = number * 100;
                else if (unitForm2 == "mm") result = number * 1000;
                else if (unitForm2 == "mi") result = number * 0.000621371192;
                else if (unitForm2 == "in") result = number * 39.3700787;
                else if (unitForm2 == "km") result = number * 0.001;
                else if (unitForm2 == "ft") result = number * 3.2808399;
                else if (unitForm2 == "yd") result = number * 1.0936133;
                break;

            case "cm":
                if (unitForm2 == "cm") result = number;
                else if (unitForm2 == "m") result = number / 100.0;
                else if (unitForm2 == "mm") result = number * 10;
                else if (unitForm2 == "km") result = number / 100000.0;
                else if (unitForm2 == "mi") result = number * 0.0000062137;
                else if (unitForm2 == "in") result = number * 0.393700787;
                else if (unitForm2 == "ft") result = number * 0.032808399;
                else if (unitForm2 == "yd") result = number * 0.010936133;
                break;

            case "mm":
                if (unitForm2 == "mm") result = number;
                else if (unitForm2 == "m") result = number / 1000.0;
                else if (unitForm2 == "cm") result = number / 10.0;
                else if (unitForm2 == "km") result = number / 1000000.0;
                else if (unitForm2 == "mi") result = number * 0.000000621371;
                else if (unitForm2 == "in") result = number * 0.0393700787;
                else if (unitForm2 == "ft") result = number * 0.0032808399;
                else if (unitForm2 == "yd") result = number * 0.0010936133;
                break;

            case "km":
                if (unitForm2 == "km") result = number;
                else if (unitForm2 == "m") result = number * 1000;
                else if (unitForm2 == "cm") result = number * 100000;
                else if (unitForm2 == "mm") result = number * 1000000;
                else if (unitForm2 == "mi") result = number * 0.621371192;
                else if (unitForm2 == "in") result = number * 39370.0787;
                else if (unitForm2 == "ft") result = number * 3280.8399;
                else if (unitForm2 == "yd") result = number * 1093.6133;
                break;

            case "mi":
                if (unitForm2 == "mi") result = number;
                else if (unitForm2 == "m") result = number * 1609.34;
                else if (unitForm2 == "km") result = number * 1.60934;
                else if (unitForm2 == "cm") result = number * 160934;
                else if (unitForm2 == "mm") result = number * 1609340;
                else if (unitForm2 == "in") result = number * 63360;
                else if (unitForm2 == "ft") result = number * 5280;
                else if (unitForm2 == "yd") result = number * 1760;
                break;

            case "in":
                if (unitForm2 == "in") result = number;
                else if (unitForm2 == "cm") result = number * 2.54;
                else if (unitForm2 == "mm") result = number * 25.4;
                else if (unitForm2 == "m") result = number * 0.0254;
                else if (unitForm2 == "km") result = number * 0.0000254;
                else if (unitForm2 == "mi") result = number * 0.0000157828;
                else if (unitForm2 == "ft") result = number * 0.0833333;
                else if (unitForm2 == "yd") result = number * 0.0277778;
                break;

            case "ft":
                if (unitForm2 == "ft") result = number;
                else if (unitForm2 == "m") result = number * 0.3048;
                else if (unitForm2 == "cm") result = number * 30.48;
                else if (unitForm2 == "mm") result = number * 304.8;
                else if (unitForm2 == "km") result = number * 0.0003048;
                else if (unitForm2 == "mi") result = number * 0.000189394;
                else if (unitForm2 == "in") result = number * 12;
                else if (unitForm2 == "yd") result = number * 0.333333;
                break;

            case "yd":
                if (unitForm2 == "yd") result = number;
                else if (unitForm2 == "m") result = number * 0.9144;
                else if (unitForm2 == "cm") result = number * 91.44;
                else if (unitForm2 == "mm") result = number * 914.4;
                else if (unitForm2 == "km") result = number * 0.0009144;
                else if (unitForm2 == "mi") result = number * 0.000568182;
                else if (unitForm2 == "in") result = number * 36;
                else if (unitForm2 == "ft") result = number * 3;
                break;
        }

        Console.WriteLine(Math.Round(result, 10) + " " + unitForm2);
    }
}