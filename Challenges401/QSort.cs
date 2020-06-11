using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Challenges
{
    public class QSort
    {
        static public int[] QuickSort(int[] inputArray)
        {
            return QuickSort(inputArray, 0, inputArray.Length - 1);
        }

        static private int[] QuickSort(int[] inputArray, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(inputArray, left, right);

                if (pivot > 1)
                {
                    QuickSort(inputArray, left, pivot - 1);
                }

                if (pivot + 1 < right)
                {
                    QuickSort(inputArray, pivot + 1, right);
                }
            }

            return inputArray;
          
        }


        private static int Partition(int[] inputArray, int left, int right)
        {
            int pivot = inputArray[left];
            while (true)
            {
                while (inputArray[left] < pivot)
                {
                    left++;
                }
                while (inputArray[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (inputArray[left] == inputArray[right])
                    {
                        return right;
                    }

                    int temp = inputArray[left];
                    inputArray[left] = inputArray[right];
                    inputArray[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
