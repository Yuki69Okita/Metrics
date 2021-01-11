using System;
using System.Collections.Generic;

namespace Metriki
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Before optimization
            Console.WriteLine("Type the needed value.");
            Console.WriteLine("Excurion:");
            double exursion = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the needed quantity.");
            Console.WriteLine("Puzzels:");
            int puzzels = int.Parse(Console.ReadLine());
            Console.WriteLine("Dolls:");
            int dolls = int.Parse(Console.ReadLine());
            Console.WriteLine("Bears:");
            int bears = int.Parse(Console.ReadLine());
            Console.WriteLine("Minions:");
            int minions = int.Parse(Console.ReadLine());
            Console.WriteLine("Trucks:");
            int trucks = int.Parse(Console.ReadLine());

            if (exursion < 0 || puzzels < 0 || dolls < 0 || bears < 0 || minions < 0 || trucks < 0)
            {
                Console.WriteLine("Error!");
                Console.WriteLine("Numbers can't be negative here!");

                return;
            }
            else
            {
                double finalle;
                double moneyEarnd = (puzzels * 2.60) + (dolls * 3) + (bears * 4.10) + (minions * 8.20) + (trucks * 2);
                double quantity = puzzels + dolls + bears + minions + trucks;

                if (quantity >= 50)
                {
                    double discount = moneyEarnd - (moneyEarnd * 0.25);
                    finalle = discount - (discount * 0.10);
                }
                else
                {
                    finalle = moneyEarnd - (moneyEarnd * 0.10);
                }

                if (finalle >= exursion)
                {
                    Console.WriteLine($"Yes! {Math.Round((finalle - exursion), 2)} lv left");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {Math.Round((exursion - finalle), 2)} lv needed.");
                }
            }
            #endregion

            
            #region After optimization
            //Console.WriteLine("Type the needed value.");
            //Console.WriteLine("Excurion:");
            //double exursion = double.Parse(Console.ReadLine());

            //Console.WriteLine("Type the needed quantity.");
            //Console.WriteLine("Puzzels:");
            //int puzzels = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dolls:");
            //int dolls = int.Parse(Console.ReadLine());

            //Console.WriteLine("Bears:");
            //int bears = int.Parse(Console.ReadLine());

            //Console.WriteLine("Minions:");
            //int minions = int.Parse(Console.ReadLine());

            //Console.WriteLine("Trucks:");
            //int trucks = int.Parse(Console.ReadLine());

            //double[] all = { exursion, puzzels, dolls, bears, minions, trucks };

            //for (int i = 0; i < all.Length; i++)
            //{
            //    double a = all[i];
            //    if (a < 0)
            //    {
            //        Console.WriteLine("Error!");
            //        Console.WriteLine("Numbers can't be negative here!");

            //        return;
            //    }
            //}

            //double moneyEarnd = (puzzels * 2.60) + (dolls * 3) + (bears * 4.10) + (minions * 8.20) + (trucks * 2);
            //double quantity = puzzels + dolls + bears + minions + trucks;
            //double finalle;

            //if (quantity >= 50)
            //{
            //    double discount = moneyEarnd - (moneyEarnd * 0.25);
            //    finalle = discount - (discount * 0.10);
            //}
            //else
            //{
            //    finalle = moneyEarnd - (moneyEarnd * 0.10);

            //}

            //if (finalle >= exursion)
            //{
            //    Console.WriteLine($"Yes! {Math.Round((finalle - exursion), 2)} lv left");
            //}
            //else
            //{
            //    Console.WriteLine($"Not enough money! {Math.Round((exursion - finalle), 2)} lv needed.");
            //}
            #endregion
        }
    }
}
