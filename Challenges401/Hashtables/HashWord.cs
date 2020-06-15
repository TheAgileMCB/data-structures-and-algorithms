using DataStructures.Hashtables;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Challenges.Hashtables
{
    public class HashWord
    {
        public static string RepeatedWord(string longString)
        {
            var rx = new Regex(@"\s+", RegexOptions.Compiled);
            string lowerString = longString.ToLower();
            string[] stringArr = rx.Split(lowerString);

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
