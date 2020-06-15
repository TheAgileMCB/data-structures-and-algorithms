using DataStructures.Hashtables;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Hashtables
{
    public class HashWord
    {
        public static string RepeatedWord(string longString)
        {
            char[] splitters = new char[] {' ', ', ', '/'};
            string[] stringArr = longString.ToLower().Split(splitters);

            Hashtable stringHash = new Hashtable(stringArr.Length);
            //foreach (string item in stringArr)
            //{
            //    stringHash.Add(item, item);
            //}
                for (int i = 0; i < stringArr.Length; i++)
                {
                    //stringHash.Get(stringArr[i]);
                    if (stringHash.Contains(stringArr[i]))
                        return stringArr[i];

                    stringHash.Add(stringArr[i], stringArr[i]);
                }
            return "There are no repeated words!";
        }
    }
}
