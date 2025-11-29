using System;

public class Program
{
    const double BGNtoUSD = 1.79549;
    const double BGNtoEUR = 1.95583;
    const double BGNtoGBP = 2.53405;
    const double USDtoEUR = 0.91801945976;
    const double USDtoGBP = 0.7085456088;
    const double EURtoUSD = 1.08930152772;
    const double EURtoGBP = 0.7718198141;
    const double GBPtoUSD = 1.4113417507;
    const double GBPtoEUR = 1.2956391915;

    public static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        string moneyName1 = (Console.ReadLine());
        string moneyName2 = (Console.ReadLine());
        if (moneyName1 == "BGN")
        {
            if (moneyName2 == "USD")
            {
                Console.WriteLine($"{money / BGNtoUSD:f2} USD");
            }
            else if (moneyName2 == "EUR")
            {
                Console.WriteLine($"{money / BGNtoEUR:f2} EUR");
            }
            else
            {
                Console.WriteLine($"{money / BGNtoGBP:f2} GBP");
            }
        }
        else if (moneyName1 == "USD")
        {
            if (moneyName2 == "BGN")
            {
                Console.WriteLine($"{money * BGNtoUSD:f2} BGN");
            }
            else if (moneyName2 == "EUR")
            {
                Console.WriteLine($"{money * USDtoEUR:f2} EUR");
            }
            else
            {
                Console.WriteLine($"{money * USDtoGBP:f2} GBP");
            }
        }
        else if (moneyName1 == "EUR")
        {
            if (moneyName2 == "BGN")
            {
                Console.WriteLine($"{money * BGNtoEUR:f2} BGN");
            }
            else if (moneyName2 == "USD")
            {
                Console.WriteLine($"{money * EURtoUSD:f2} USD");
            }
            else
            {
                Console.WriteLine($"{money * EURtoGBP:f2} GBP");
            }
        }
        else
        {
            if (moneyName2 == "BGN")
            {
                Console.WriteLine($"{money * BGNtoGBP:f2} BGN");
            }
            else if (moneyName2 == "USD")
            {
                Console.WriteLine($"{money * GBPtoUSD:f2} USD");
            }
            else
            {
                Console.WriteLine($"{money * GBPtoEUR:f2} EUR");
            }
        }
    }
}