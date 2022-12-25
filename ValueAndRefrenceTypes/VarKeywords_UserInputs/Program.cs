namespace VarKeywords_UserInputs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your name");
            var x = Console.ReadLine();
            Console.WriteLine($"hello {x}!");

            Console.ReadKey();


        }
    }
}