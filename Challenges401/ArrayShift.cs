using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class ArrayShift
    {
        public static int[] insertShiftArray(int[] array, int numberToInsert)
        {
            decimal middleIndex = Math.Ceiling(array.Length / 2m);

            int[] newArray = new int[array.Length + 1];

            for(int i = 0; i < newArray.Length; i++)
            {
                if (i < middleIndex)
                {
                    newArray[i] = array[i];
                }
                else if (i == middleIndex)
                {
                    newArray[i] = numberToInsert;
                }
                else
                {
                    newArray[i] = array[i - 1];
                }
            }

            return newArray;
        }
        
        public static decimal middleIndex(decimal arrLength)
        {
            decimal newArrLength = Math.Round(arrLength / 2, 0,
                MidpointRounding.AwayFromZero);
            return newArrLength;
        }
    }

}
