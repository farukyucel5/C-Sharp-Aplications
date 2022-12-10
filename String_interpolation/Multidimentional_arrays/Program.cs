namespace Multidimentional_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            String[,] parkingLot = { { "Mustang", "F-150", "Explorer" },
                                                   { "Corvette", "Camaro", "Silverado"},
                                                   { "Corolla", "Camry", "Rav4" }
                                                 };

            parkingLot[0, 2] = "Fusion";
            parkingLot[2, 0] = "Tacoma";
            /*
            foreach(String car in parkingLot)
            {
                Console.WriteLine(car);
            }
            */

            Console.WriteLine(parkingLot.Rank);//dizinin boyutunu verir uzunluğunu değil!!
            //output=2 çünkü iki boyutlu bir array

            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }



            // Two-dimensional array.
            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // The same array with dimensions specified.
            int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // A similar array with string elements.
            string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                        { "five", "six" } };

            
            // Accessing array elements.
            Console.WriteLine(array2D[0, 0]);
            Console.WriteLine(array2D[0, 1]);
            Console.WriteLine(array2D[1, 0]);
            Console.WriteLine(array2D[1, 1]);
            Console.WriteLine(array2D[3, 0]);
            Console.WriteLine(array2Db[1, 0]);
         

            // Getting the total count of elements or the length of a given dimension.
            var allLength = array2D.Length;
            var total = 1;
            for (int i = 0; i < array2D.Rank; i++)
            {
                total *= array2D.GetLength(i);
            }
            Console.WriteLine("{0} equals {1}", allLength, total);

            // Output:
            // 1
            // 2
            // 3
            // 4
            // 7
            // three
            // 8
            // 12
            // 12 equals 12

            int[,] array5;
            array5 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };   // OK
            //array5 = {{1,2}, {3,4}, {5,6}, {7,8}};   // Error

            array5[2, 1] = 25;//The following example assigns a value to a particular array element.

            //Similarly, the following example gets the value of a particular array element
            //and assigns it to variable elementValue.

            int elementValue = array5[2, 1];
            //The following code example initializes the array elements to default values
            //(except for jagged arrays).

            int[,] array6 = new int[10, 10];

            Console.ReadKey();
        }
    }
}