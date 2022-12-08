namespace CsharpLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while loop = repeats some code while some condition remains true

            /* String name = "";

             while (name == "")
             {
                 Console.Write("Enter your name: ");
                 name = Console.ReadLine();
             }

             Console.WriteLine("Hello " + name);

             Console.ReadKey();*/



            // for loop = repeats some code a FINITE amount of times

            // Count up to 10
            /*
             for (int i = 1; i <= 10; i++)
             {
                 Console.WriteLine(i);
             }

             // Count down from 10
             for (int i = 10; i > 0; i--)
             {
                 Console.WriteLine(i);
             }
             Console.WriteLine("HAPPY NEW YEAR!");*/

            // nested loops = loops inside of other loops
            //                Uses vary. Used a lot in sorting algorithms

            Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.ReadKey();

            Console.ReadKey();
        }
    }
    }