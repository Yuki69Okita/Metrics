using System;

namespace Metriki4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Before optimization
            Console.WriteLine("Enter number of rows:");
            int number = int.Parse(Console.ReadLine());
            int count = number - 1;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    Console.Write(" ");
                }
                count--;

                for (int y = 1; y <= 2 * i - 1; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            count = 1;
            for (int i = 1; i <= number - 1; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    Console.Write(" ");
                }
                count++;

                for (int y = 1; y <= 2 * (number - i) - 1; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion

            #region After optimization
            //Console.WriteLine("Enter number of rows:");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    for (int j = 1; j <= number - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int y = 1; y <= 2 * i - 1; y++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}

            //for (int i = number - 1; i >= 1; i--)
            //{
            //    for (int j = 1; j <= number - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int y = 1; y <= 2 * i - 1; y++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
        }
    }
}
