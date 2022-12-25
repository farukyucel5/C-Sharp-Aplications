namespace ValueAndRefrenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //integers are value type in c#

            int a = 3;
            int b = a;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine("changed version");

            b = 2;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine("Arrays...");

            //arrays are refrence type in c#

            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] arr2 = arr1;

            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr2[0]);

            Console.WriteLine("changed");

            arr2[0] = 23;


            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr2[0]);

            Console.WriteLine("----------------------------");

               int[] ints = { 1, 2, 3 };

            Console.WriteLine(ints[0]);

                Test(ints);

            Console.WriteLine(ints[0]);

            Console.WriteLine("-------------------------------");

            int x = 3;//integers are passing by value so it wont be changed after test method
            Console.WriteLine(x);
            Test(x);
            Console.WriteLine(x);
            
                




        }

        public static void Test(int[] x)
        {
            x[0]= 23;


        }

        public static void Test(int x)
        {
            x = 23;


        }






    }
}