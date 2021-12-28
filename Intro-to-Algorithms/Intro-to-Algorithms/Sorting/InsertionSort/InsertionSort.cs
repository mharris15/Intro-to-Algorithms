using System;


/* Pseudo code 
    INSERTION-SORT(A)
    1 for i = 0 to A.length
    2   key = A[i]
    3   // Insert A(i)  into the sorted sequence A[1 . . . i - 1]
    4   j = i - 1
    5   while j >= 0 and A[j] > key
    6       A[j + 1] = A[j]
    7       j = j - 1
    8   A[j + 1] = key
 */

namespace Intro_To_Algorithms.Sorting
{
    class InsertionSort
    {
        public int[] Sort(int[] arr)
        {
            // Insertion sort algo 
            for(int i = 0; i < arr.Length;i++)
            {
                int key = arr[i];
                int j = i - 1;
                while(j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1; 
                }
                arr[j + 1] = key;
            }
            return arr;
        }

        public void PrintArray(int[] arr)
        {
            // Print array
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "\n");
            }
        }
    }
}
