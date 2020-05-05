using System;
using static Challenges.ArrayReverse;

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
        
    }
}


