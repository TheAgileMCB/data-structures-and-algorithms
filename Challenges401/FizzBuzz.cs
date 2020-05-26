
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
            BinarySearchTree<string> stringTree = new BinarySearchTree<string>();


            foreach (var item in treeEnumerable)
            {
                if (item % 15 == 0)
                {
                    stringTree.Add("FizzBuzz");
                }
                else if (item % 5 == 0)
                {
                    stringTree.Add("Buzz");
                }
                else if (item % 3 == 0)
                    stringTree.Add("Fizz");

                else stringTree.Add(treeEnumerable[item].ToString());
            }
            return stringTree;
        }
    }
}
