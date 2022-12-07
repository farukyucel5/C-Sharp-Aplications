namespace ConsoleApp7Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >100)
            {
                Console.WriteLine("You cannot be alive");
            }
            else if (age>=18)
            {
                Console.WriteLine("You are now signed up!!");
            }
            else if (age < 0)
            {
                Console.WriteLine("You haven't been born yet");
            }
            else
            {
                Console.WriteLine("you must be 18+ to sign up!");
            }

            Console.WriteLine("Please enter you name ");
            String name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("Enter your name!!");
            }
            else
            {
                Console.WriteLine("Hello " + name);
            }








            Console.ReadKey();
        }
    }
}