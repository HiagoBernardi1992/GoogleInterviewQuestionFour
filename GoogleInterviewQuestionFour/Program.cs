using System;
using System.Collections.Generic;
using System.Linq;

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

            string GetLongestWordSubsequence(string s, IList<string> d)
            {
                //First I sort the list so that I can sure that I always work with the higher string first
                var sorted = d.OrderByDescending(x => x.Length).ThenBy(x => x);
                //I do a loop to check one by one
                foreach (string str in sorted)
                {
                    //here is one variable to interate at the char of the string sorted
                    int i = 0;
                    //and here I do a loop to interate at the string to check
                    for (int j = 0; j < s.Length; j++)
                    {
                        //if is equals means that the word sorted of the inteartion is in the sequence of the srting to check
                        if (s[j] == str[i])
                            i++;

                        // here I compare the interation of the string sorted with the size of the string to check
                        // if is equal it means that all the characters if the sorted string is in the sequence of the string to check
                        // and I know that this string is the higher one, because I have done the sorted.
                        if (i == str.Length)
                            return str;
                    }
                }

                return "";
            }


        }
    }
}
