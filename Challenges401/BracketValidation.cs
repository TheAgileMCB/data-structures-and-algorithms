using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using DataStructures;

namespace Challenges
{
    class BracketValidation
    {
        public static bool IsBalanced(string input)
        {
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
            {
                { '{', '}'},
                { '(', ')'},
                { '<', '>'},
                { '[', ']'},
             };

            Stack<char> brackets = new Stack<char>();

            try
            {
                foreach (char item in input)
                {
                    if (bracketPairs.Keys.Contains(item))
                    {
                        brackets.Push(item);

                        if (bracketPairs.Values.Contains(item))
                        {
                            if (item == brackets.First())
                            {
                                brackets.Pop();
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }

                        continue;
                    }

                }
            }
            catch 
            {

                return false;
            }

            if (brackets.Count == 0)
            {
                return true;
            }
        }

    }
}
