namespace Conditional_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // conditional operator = used in conditional assignment if a condition is true/false

            //(condition) ? x : y

            double temperature = 20;
            String message;

            message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";

            Console.WriteLine(message);

            int num = 1;

            while (num != 0)
            {
                Console.WriteLine("enter in a number");
                num= Convert.ToInt32(Console.ReadLine());

                int number = (num > 0) ? num * num : num * (-1);

                Console.WriteLine(number);


            }

            Console.ReadKey();
        }
    }
}