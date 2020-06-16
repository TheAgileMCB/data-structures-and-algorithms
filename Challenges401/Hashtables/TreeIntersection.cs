using DataStructures.BinaryTrees;
using DataStructures.Hashtables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges.Hashtables
{
    public class TreeIntersection
    {
        public static List<string> Tree_Intersection(DataStructures.BinaryTrees.BinarySearchTree<int> treeOne, DataStructures.BinaryTrees.BinarySearchTree<int> treeTwo)
        {
            Hashtable myTable = new Hashtable(7);
            List<string> returnList = new List<string>();

            foreach (int value in treeOne.PreOrder(treeOne.ReturnRoot()))
            {
                string keyOne = value.ToString();
                myTable.Add(keyOne, null);
            }
            foreach (int value in treeTwo.PreOrder(treeTwo.ReturnRoot()))
            {
                string keyTwo = value.ToString();
                if (myTable.Contains(keyTwo))
                {
                    returnList.Add(keyTwo);
                }
            }

            return returnList;
        }
    }
}
