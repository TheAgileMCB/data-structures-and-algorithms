using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class ArrayMethods
    {
        public static int BinarySearch(int key, int[] array)
        {
            // set minimum index
            int min = 0;
            // set maximum index
            int max = array.Length - 1;

            // loop through array until key is ofund
            while (min <= max)
            {
                // formula to calculate midpoint
                int midpoint = (min + max) / 2;
                // check for equality
            if (key == array[midpoint])
            {
                    return midpoint;
                }
            // check if key is in different rage
                else if (key < array[midpoint])
                {
                    max = midpoint - 1;
                }
            // consider other end of the range
                else
                {
                    min = midpoint + 1;
                }
            }
            // return -1 if key is not found
            return -1;
        }
    }
}
