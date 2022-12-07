namespace ConsoleApp5UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the name");
            String name = Console.ReadLine();
            

            Console.WriteLine("Enter the age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("you are " + age+" years old!");
           





        }
    }
}