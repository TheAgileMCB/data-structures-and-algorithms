
using DataStructures.BinaryTrees;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class FizzBuzz 
    {
        public static BinarySearchTree<string> FizzBuzzTree(BinarySearchTree<int> tree)
        {
            IEnumerable<int> treeEnumerable = tree.PreOrder(tree.ReturnRoot());
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

                else stringTree.Add(item.ToString());
            }
            return stringTree;
        }
    }
}
