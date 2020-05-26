
using DataStructures.BinaryTrees;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class FizzBuzz 
    {
        public BinarySearchTree<string> FizzBuzzTree(BinarySearchTree<int> tree)
        {
            int[] treeEnumerable = (int[])tree.PreOrder(tree.ReturnRoot());

            foreach (var item in treeEnumerable)
            {
                if (item % 15 == 0)
                {
                    treeEnumerable[item].ToString();
                    treeEnumerable[item] = "FizzBuzz";
                }
                else if (item % 5 == 0)
                {
                    item.ToString();
                    item = "Buzz";
                }
                else if (item % 3 == 0)
                    return "Fizz";
                else item.ToString();
            }
                
        }
    }
}
