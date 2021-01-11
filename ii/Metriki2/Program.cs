using System;

namespace Metriki2
{
    class Program
    {
        public static double ConvertCurrency(string currency)
        {
            switch (currency)
            {
                case "BGN":
                    return 1;

                case "USD":
                    return 1.79549;

                case "EUR":
                    return 1.95583;

                case "GBP":
                    return 2.53405;

                default:
                    Console.WriteLine("Error!");
                    return 0;
            }
        }

        static void Main(string[] args)
        {
            #region Before optimization
            Console.WriteLine("Value:");
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine("First currency:");
            string firstCurrency = Console.ReadLine().ToLower();
            Console.WriteLine("Second currency:");
            string secondCurrency = Console.ReadLine().ToLower();

            double usd = 1.79549;
            double eur = 1.95583;
            double gbp = 2.53405;

            if (firstCurrency == "eur" && secondCurrency == "gbp")
            {
                Console.WriteLine($"{(money * eur) / gbp:F2} GBP");
            }
            else if (firstCurrency == "eur" && secondCurrency == "usd")
            {
                Console.WriteLine($"{(money * eur) / usd:F2} USD");
            }
            else if (firstCurrency == "eur" && secondCurrency == "bgn")
            {
                Console.WriteLine($"{(money * eur):F2} BGN");
            }
            else if (firstCurrency == "usd" && secondCurrency == "gbp")
            {
                Console.WriteLine($"{(money * usd) / gbp:F2} GBP");
            }
            else if (firstCurrency == "usd" && secondCurrency == "eur")
            {
                Console.WriteLine($"{(money * usd) / eur:F2} EUR");
            }
            else if (firstCurrency == "usd" && secondCurrency == "bgn")
            {
                Console.WriteLine($"{(money * usd):F2} BGN");
            }
            else if (firstCurrency == "gbp" && secondCurrency == "eur")
            {
                Console.WriteLine($"{(money * gbp) / eur:F2} EUR");
            }
            else if (firstCurrency == "gbp" && secondCurrency == "usd")
            {
                Console.WriteLine($"{(money * gbp) / usd:F2} USD");
            }
            else if (firstCurrency == "gbp" && secondCurrency == "bgn")
            {
                Console.WriteLine($"{(money * gbp):F2} BGN");
            }
            else if (firstCurrency == "bgn" && secondCurrency == "eur")
            {
                Console.WriteLine($"{money / eur:F2} EUR");
            }
            else if (firstCurrency == "bgn" && secondCurrency == "usd")
            {
                Console.WriteLine($"{money / usd:F2} USD");
            }
            else if (firstCurrency == "bgn" && secondCurrency == "gbp")
            {
                Console.WriteLine($"{(money / gbp):F2} GBP");
            }
            else
            {
                Console.WriteLine("Error!");
            }
            #endregion

            #region After optimization
            //Console.WriteLine("Value:");
            //double money = double.Parse(Console.ReadLine());
            //Console.WriteLine("First currency:");
            //string firstCurrency = Console.ReadLine().ToLower();
            //Console.WriteLine("Second currency:");
            //string secondCurrency = Console.ReadLine().ToLower();

            //double usd = 1.79549;
            //double eur = 1.95583;
            //double gbp = 2.53405;

            //if (firstCurrency == "eur")
            //{
            //    if (secondCurrency == "gbp")
            //    {

            //        Console.WriteLine($"{(money * eur) / gbp:F2} GBP");
            //    }
            //    else if (secondCurrency == "usd")
            //    {
            //        Console.WriteLine($"{(money * eur) / usd:F2} USD");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{(money * eur):F2} BGN");
            //    }
            //}
            //else if (firstCurrency == "usd")
            //{
            //    if (secondCurrency == "gbp")
            //    {
            //        Console.WriteLine($"{(money * usd) / gbp:F2} GBP");
            //    }
            //    else if (secondCurrency == "eur")
            //    {
            //        Console.WriteLine($"{(money * usd) / eur:F2} EUR");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{(money * usd):F2} BGN");
            //    }
            //}
            //else if (firstCurrency == "gbp")
            //{
            //    if (secondCurrency == "eur")
            //    {
            //        Console.WriteLine($"{(money * gbp) / eur:F2} EUR");
            //    }
            //    else if (secondCurrency == "usd")
            //    {
            //        Console.WriteLine($"{(money * gbp) / usd:F2} USD");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{money * gbp:F2} BGN");
            //    }
            //}
            //else if (firstCurrency == "bgn")
            //{
            //    if (secondCurrency == "eur")
            //    {
            //        Console.WriteLine($"{(money / eur):F2} EUR");
            //    }
            //    else if (secondCurrency == "usd")
            //    {
            //        Console.WriteLine($"{(money / usd):F2} USD");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{(money / gbp):F2} BGN");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error!");
            //}
            #endregion

            #region After second optimization
            //Console.WriteLine("Value:");
            //double money = double.Parse(Console.ReadLine());

            //Console.WriteLine("First currency:");
            //string firstCurrency = Console.ReadLine().ToUpper();

            //Console.WriteLine("Second currency:");
            //string secondCurrency = Console.ReadLine().ToUpper();

            //double firstValue = ConvertCurrency(firstCurrency);
            //double secondValue = ConvertCurrency(secondCurrency);
            //double result = (firstValue / secondValue) * money;

            //Console.WriteLine($"{result:F2} {secondCurrency}");
            #endregion
        }
    }
}
