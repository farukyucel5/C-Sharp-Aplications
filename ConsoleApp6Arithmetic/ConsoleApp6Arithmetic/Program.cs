namespace ConsoleApp6Arithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*
            int i = 5;
            i += 2;
            i++;

            Console.WriteLine(i);

            i -= 2;
            i--;

            Console.WriteLine(i);
            i *= 2;

            Console.WriteLine(i);

            i /= 2;
            Console.WriteLine(i);

            int remainder = i % 2;
            Console.WriteLine(remainder);
          */
            double x = 3;
            double y = -4;
            double z=17.96789;
            double p = 5;


            double a = Math.Pow(x, 2);//9
            double b = Math.Sqrt(x);
            double c = Math.Abs(y);
            double d = Math.Round(z);//it rounds up or down depends on the decimal portions
            double e = Math.Ceiling(z);//it always rounds up the value
            double f = Math.Floor(z);//it always rounds down the value;
            double g = Math.Max(z, p);//it finds the max value
            double h = Math.Min(z, p);//it finds the min value


            ;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);



            Console.ReadKey();






        }
    }
}