namespace ConsoleApp7StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String fullname = "Faruk yucel";
            String phoneNumber = "123-456-7890";

            String fullname1 = fullname.ToUpper();
            String fullname2 = fullname.ToLower();
            String phonenum = phoneNumber.Replace("-", "/");
            String phonenum1 = phoneNumber.Replace("-", "");
            String username = fullname.Insert(0, "@");
            String username2 = fullname.Insert(0, "Mr.");
            



            Console.WriteLine(fullname1);

            Console.WriteLine(fullname2);

            Console.WriteLine(phonenum);
            Console.WriteLine(phonenum);
            Console.WriteLine(username);
            Console.WriteLine(username2);

            Console.WriteLine("Your name has "+fullname.Length+ " characters");

            //.Substring(startIndex,length of the substring );
            String firstname = fullname.Substring(0, 5);
            Console.WriteLine(firstname);

            String lastname = fullname.Substring(6,5);
            Console.WriteLine(lastname);






            Console.ReadKey();
        }
    }
}