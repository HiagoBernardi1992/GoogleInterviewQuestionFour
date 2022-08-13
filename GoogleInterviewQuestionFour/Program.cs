using System;
using System.Collections.Generic;

namespace GoogleInterviewQuestionFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    The Challenge
            //    Given a string S and a set of words D, find the longest word in D that is a subsequence of S.
            //    Word W is a subsequence of S if some number of characters, possibly zero, can be deleted from S to form W, without reordering the remaining characters.
            //    Note: D can appear in any format(list, hash table, prefix tree, etc.
            //    For example, given the input of S = "abppplee" and D = { "able", "ale", "apple", "bale", "kangaroo"}
            //                the correct output would be "apple"
            //    The words "able" and "ale" are both subsequences of S, but they are shorter than "apple".
            //    The word "bale" is not a subsequence of S because even though S has all the right letters, they are not in the right order.
            //    The word "kangaroo" is the longest word in D, but it isn't a subsequence of S.
            //    Learning objectives
            //    This question gives you the chance to practice with algorithms and data structures.It’s also a good example of why careful analysis for Big - O performance is often worthwhile, as is careful exploration of common and worst -case input conditions.
            string s = "abppplee";
            string[] d = { "able", "ale", "apple", "bale", "kangaroo" };
            var response = GetLongestWordSubsequence(s, d);
            Console.WriteLine("Expected: apple");
            Console.WriteLine("Result: " + response);

            string GetLongestWordSubsequence(string s, string[] d)
            {            
                HashSet<string> set = new HashSet<string>(d);
                List<string> list = new List<string>();
                generate(s, "", 0, list);
                string max_str = "";
                foreach(string str in list)
                {
                    if (set.Contains(str))
                    {
                        if (str.Length > max_str.Length || (str.Length == max_str.Length && str.CompareTo(max_str) < 0))
                        {
                            max_str = str;
                        }
                            
                    }                        
                }
                return max_str;
            }

            void generate(string s, string str, int i, List<string> l)
            {
                if (i == s.Length)
                    l.Add(str);
                else
                {
                    generate(s, str + s[i], i + 1, l);
                    generate(s, str, i + 1, l);
                }
            }

        }
    }
}
