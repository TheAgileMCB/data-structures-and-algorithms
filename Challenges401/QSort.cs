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
        public static int[] QuickSort(int[] inputArray)
        {
            return QuickSort(inputArray, 0, inputArray.Length - 1);
        }

        private static int[] QuickSort(int[] inputArray, int left, int right)
        {
            if (left < right)
            {
                int pivot = partition(inputArray, left, right);

                    QuickSort(inputArray, left, pivot - 1);
    
                    QuickSort(inputArray, pivot + 1, right);
            }

            return inputArray;
        }

        private static int partition(int[] inputArray, int left, int right)
        {
            int pivot = inputArray[right];
            int low = left - 1;

            for (int i = left; i < right - 1; i++)
            {
                if (inputArray[i] <= pivot)
                {
                    low++;
                    swap(inputArray, low, i);
                }
            }
            swap(inputArray, low + 1, right);
            return low + 1;
        }

        private static void swap(int[] arr, int i, int low)
        {
            var temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}

