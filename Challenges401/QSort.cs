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
                int pivot = partition(inputArray, left, right);

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


        private static int partition(int[] inputArray, int left, int right)
        {
            int pivot = inputArray[right];
            int i = left - 1;

            for (int j = left; j < right - 1; j++)
            {
                if (inputArray[j] <= pivot)
                {
                    i++;
                    swap(inputArray, i, j);
                }
            }
            swap(inputArray, i + 1, right);
            return i + 1;
        }

        private static void swap(int[] arr, int i, int high)
        {
            var temp = arr[i];
            arr[i] = arr[high];
            arr[high] = temp;
        }
    }
}

