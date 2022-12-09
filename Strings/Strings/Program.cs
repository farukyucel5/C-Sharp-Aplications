namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string concatination

            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);

            //You can also use the string.Concat() method to concatenate two strings:

            string firstName1 = "John ";
            string lastName1 = "Doe";
            string name1 = string.Concat(firstName1, lastName1);
            Console.WriteLine(name1);

        

            /*
             * WARNING!

C            *# uses the + operator for both addition and concatenation.

R            *emember: Numbers are added. Strings are concatenated.


            If you add two numbers, the result will be a number:

            If you add two strings, the result will be a string concatenation:

            */
            int x = 10;
            int y = 20;
            int z = x + y;  // z will be 30 (an integer/number)
            Console.WriteLine(z);
            string x1 = "10";
            string y1= "20";
            string z1 = x1 + y1;  // z will be 1020 (a string)
            Console.WriteLine(z1);


            /*String Interpolation
             
             Another option of string concatenation, is string interpolation, 
             which substitutes values of variables into placeholders in a string. 
             Note that you do not have to worry about spaces, like with concatenation:

            Also note that you have to use the dollar sign ($)
            when using the string interpolation method.
            String interpolation was introduced in C# version 6.
             */

            string firstName2 = "John";
            string lastName2 = "Doe";
            string name2 = $"My full name is: {firstName2} {lastName2}";
            Console.WriteLine(name2);


            Console.WriteLine($"My name is: {firstName2} {lastName2}");


            int sayı1 = 30;
            int sayı2 = 40;
            int sum = sayı1 + sayı2;

            Console.WriteLine($"The sum of {sayı1}+{sayı2}={sum}");

            /*You can access the characters in a string by referring to its index number 
             * inside square brackets [].
             *  This example prints the first character in myString:*/


            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"

            string myString1 = "world";
            Console.WriteLine(myString1[1]);  // Outputs "o"
            /*You can also find the index position of a specific character in a string, 
             * by using the IndexOf() method:
             */

            string myString3 = "Hello";
            Console.WriteLine(myString3.IndexOf("e"));  // Outputs "1"

            /*Another useful method is Substring(), which extracts the characters from a string,
             * starting from the specified character position/index, and returns a new string.
             * This method is often used together with IndexOf() to get the specific character position:
             */

            // Full name
            string name3 = "John Doe";

            // Location of the letter D
            int charPos = name.IndexOf("D");

            // Get last name
            string lastName3 = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName3);


            string str = "GeeksForGeeks";
            str=str.Substring(0, 8);//and also we can use it with a start index and an end index.
            Console.WriteLine(str);

            str = "GeeksForGeeks";
            str=str.Substring(5, 3);
            Console.WriteLine(str);

            





            Console.ReadKey();



        }
    }
}