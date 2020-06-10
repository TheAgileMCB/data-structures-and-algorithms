using System;
using System.Collections.Generic;
using System.Linq;
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

        public static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if(left.Count > 0 && right.Count > 0)
                {
                    if(left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if(left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if(right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }

            return result;
        }
    }
}
