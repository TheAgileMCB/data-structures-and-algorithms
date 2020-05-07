using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class ArrayMethods
    {
        public static int BinarySearch(int key, int[] array)
        {
            int min = 0;
            int max = array.Length - 1;

            while (min <= max)
            {
                int midpoint = (min + max) / 2;
            if (key == array[midpoint])
            {
                    return midpoint;
                }
                else if (key < array[midpoint])
                {
                    max = midpoint - 1;
                }
                else
                {
                    min = midpoint + 1;
                }
            }
            return -1;
        }
    }
}
