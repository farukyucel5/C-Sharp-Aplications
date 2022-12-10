namespace String_interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string interpolation = allows us to insert variables into a string literal
            //                        precede a string literal with $
            //                        {} are placeholders

            String firstName = "Bro";
            String lastName = "Code";
            int age = 21;

            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"You are {age} years old.");
            Console.WriteLine($"You are {age,-10} years old.");//yaşın sağ tarafına boşluk atar
            Console.WriteLine($"You are {age,10} years old.");//yaşın sol tarafına boşluk atar

            Console.ReadKey();
        }
    }
}