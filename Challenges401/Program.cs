using System;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // set test array   
            int[] testArray = { 1, 2, 3, 4, 5 };

            // call function and output results
            Console.WriteLine(String.Join(", ", ReverseArray(testArray)));
        }
        
        // new function which returns an array of integers
        static int[] ReverseArray(int[] initialArray)
        {
            // create new array and set it's length equal to length of initial array
            int[] reversedArray = new int[initialArray.Length];

            // loop through initial array 
            for (int i = 0; i < initialArray.Length; i++)
            {
                // set array elements into new array in reverse order
                reversedArray.SetValue(initialArray[initialArray.Length - 1 - i], i);
            }
            // return reversed array for use in the Main
            return reversedArray;        
        }
    }
}


