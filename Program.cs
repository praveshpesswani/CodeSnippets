using System;

namespace CodeSnippets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraysOfZeroAndOne = { 1, 1, 1, 0, 1, 0, 0, 0 };
            ArraySorting arraySorting = new ArraySorting();
            int[] sortedArray = arraySorting.SortedArray(arraysOfZeroAndOne);


            Console.WriteLine("Hello World!");
        }
    }
}
