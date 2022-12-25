namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pass in the size of array you would like to create");
            int size = Convert.ToInt32(Console.ReadLine());


            int[] array = new int[size];

            for(int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(int each in array)
            {
                Console.Write(" "+each);
            }
            Console.WriteLine();

            Console.WriteLine(Array.IndexOf(array,24));//if the value exists in the array
            //it returns the index of the value but if not, it returns -1

            Array.Sort(array);//it simply sorts the array

            foreach (int each in array)
            {
                Console.Write(" " + each);
            }


            Array.Reverse(array);//it reverses the array

            Console.WriteLine();



            foreach (int each in array)
            {
                Console.Write(" " + each);
            }

            Console.WriteLine("-----------------------------------");

            char[] arr1 = { 'a', 'b', 'c' };
            char[] arr2 = { 'a', 'b', 'c' };

            if (Enumerable.SequenceEqual(arr1, arr2))
                Console.WriteLine("equal");
            else
                Console.WriteLine("not equels");




        }
    }
}