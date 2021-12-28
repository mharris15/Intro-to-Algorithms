using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Add Classes
using Intro_To_Algorithms.Sorting;



namespace Intro_To_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Insertion sort array 
            int[] arr = { 12, 11, 13, 5, 6 };
            InsertionSort insertionSort = new InsertionSort();
            arr = insertionSort.Sort(arr);
            insertionSort.PrintArray(arr);

        }
    }
}