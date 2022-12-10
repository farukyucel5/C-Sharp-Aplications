using System;
using System.Diagnostics;

namespace ParamsKeywordPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           


            double total = checkout(3.99, 5.75, 15, 34, 10.25);



            Console.WriteLine(total);

            total = checkout(3.99, 5.75, 15, 34, 10.25,45,67);

            Console.WriteLine(total);

            total = checkout(3.99, 5.75);

            Console.WriteLine(total);


            Console.ReadKey();
        }

        private static double checkout(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }
            return total;
        }
    }
}