using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int [] nums = CreateArrayOfInts(100);
            PrintArrayOfInts(nums);


        }

        static void PrintArrayOfInts(int[] nums)
        {
            foreach(int num in nums)
            {
                Console.WriteLine(num);
            }
        }

        static int [] CreateArrayOfInts(int size)
        {
            ///TODO implement this to make random array of ints of size.
            int[] nums = { 1, 2, 56, 3 };
            return nums;
        }



        static bool LinearSearch(int[] items, int searchItem)
        {
            //iterate through list and return true if item is search item

            //return false if you get to the end and haven't found it
            return false;
        }





    }
}
