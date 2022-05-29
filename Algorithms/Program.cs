using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithms World!");
            int [] nums = CreateArrayOfInts(100);
            PrintArrayOfInts(nums);

            //Test search algorithm
            Console.WriteLine("What integer are you looking for?");
            int searchItem = Convert.ToInt32(Console.ReadLine());

            TestLinearSearch(nums, searchItem);
            

            //wait for enter...
            Console.ReadLine();
        }

        static void TestLinearSearch(int[] nums, int searchItem)
        {
            bool result = LinearSearch(nums, searchItem);
            if (result)
            {
                Console.WriteLine("Item found");
            }
            else
            {
                Console.WriteLine("Item not found");
            }
        }

        static void PrintArrayOfInts(int[] nums)
        {
            //TODO it would be nicer to print these across the screen rather than one on each line.
            foreach(int num in nums)
            {
                Console.WriteLine(num);
            }
        }

        static int [] CreateArrayOfInts(int size)
        {
            ///TODO implement this to make random array of ints of size. 
            
            //Random randomNumberGenerator = new Random();
            //int num = randomNumberGenerator.Next(0, 100);

            int[] nums = { 1, 2, 56, 3 };
            return nums;
        }



        static bool LinearSearch(int[] items, int searchItem)
        {
            ///TODO iterate through list and return true if item is search item
            ///return false if you get to the end and haven't found it
            return false;
        }

        static bool BinarySearch(int[] sortedInts, int searchInt)
        {
            //TODO implement binary search
            return false;
        }

        static int[] BubbleSort(int[] nums)
        {
            //TODO implement BubbleSort on nums

            return nums;
        }

        static int[] InsertionSort(int[] nums)
        {
            //TODO implement InsertionSort on nums

            return nums;
        }

        static int[] QuickSortRecursive(int[] nums)
        {
            //TODO implement QuickSort on nums

            return nums;
        }

        static int[] QuickSortRecursiveInPlace(int[] nums)
        {
            //TODO implement QuickSort on nums inplace (i.e. without creating new lists)
            //to save memory

            return nums;
        }

        static int[] QuickSortRecursiveInPlace(int[] nums, int startIndex, int endIndex)
        {
            //TODO implement QuickSort on nums inplace (i.e. without creating new lists)
            //to save memory

            return nums;
        }

        static int[] QuickSortIterativeInPlace(int[] nums)
        {
            //TODO implement QuickSort on nums inplace (i.e. without creating new lists)
            //to save memory

            return nums;
        }
    }
}
