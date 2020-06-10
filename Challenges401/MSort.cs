using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class MSort
    {
        public static List<int> MergeSort(List<int> input)
        {
            if (input.Count <= 1)
                return input;

            int midpoint = input.Count / 2;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for(int i = 0; i <midpoint; i++)
            {
                left.Add(input[i]);
            }
            for (int i =midpoint; i < input.Count; i++)
            {
                right.Add(input[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        
    }
}
