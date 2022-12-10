namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // return  = returns data back to the place where a method is invoked
            // method overloading  = methods share same name, but different parameters
            //                       name + parameters = signature
            //                       methods must have a unique signature

            double x;
            double y;
            double result;

            Console.WriteLine("Enter in number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter in number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);
            Console.WriteLine(result);

            Console.WriteLine("Enter in number 1: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter in number 2: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter in number 3: ");
            double c = Convert.ToDouble(Console.ReadLine());


            result = Multiply(a,b,c);
            Console.WriteLine(result);

            Console.ReadKey();
        }
        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}