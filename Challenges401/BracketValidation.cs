using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using DataStructures;

// Thanks to TarunSingla; Reference material: https://www.codeproject.com/Tips/1175562/Check-for-Balanced-Parenthesis-in-a-String

namespace Challenges
{
    public class BracketValidation
    {
        public static bool IsBalanced(string input)
        {
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
            {
                { '{', '}'},
                { '(', ')'},
                { '<', '>'},
                { '[', ']'}
             };

            Stack<char> brackets = new Stack<char>();

            try
            {
                foreach (char item in input)
                {
                    if (bracketPairs.Keys.Contains(item))
                    {
                        brackets.Push(item);
                    }
                    else

                        if (bracketPairs.Values.Contains(item))
                    {
                        if (item == bracketPairs[brackets.First()])
                        {
                            brackets.Pop();
                        }
                        else
                        
                            return false;
                        
                    }
                    else
                    
                        continue;
                    
                }
            }
            catch
            {

                return false;
            }

            return brackets.Count() == 0 ? true : false;
        }

    }
}
