namespace ConsoleApp6RandomNums
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int num = random.Next(1,21);//it generates random nums between 1 and 21
            //but the upper limit value is excluded
            double num1 = random.NextDouble();//it generates random double numbers 
            //between 0 and 1
            

            Console.WriteLine(num);
            Console.WriteLine(num1);

           Console.WriteLine("=========================================0");

            //hypotenus

           Console.ReadKey();
        }
    }
}