using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.LeetCode.Problems.SentenceSimilarity
{
    /*
     * Sentence Similarity
     * 
     * We can represent a sentence as an array of words, for example, the sentence "I am happy with leetcode" can be represented as arr = ["I","am",happy","with","leetcode"].
     * 
     * Given two sentences sentence1 and sentence2 each represented as a string array and given an array of string pairs similarPairs where similarPairs[i] = [xi, yi] indicates that the two words xi and yi are similar.
     * 
     * Return true if sentence1 and sentence2 are similar, or false if they are not similar.
     * 
     * Sentences are similar if:
     * They have the same length (i.e., the same number of words)
     * sentence1[i] and sentence2[i] are similar.
     * 
     * Notice that a word is always similar to itself, also notice that the similarity relation is not transitive. For example, if the words a and b are similar, and the words b and c are similar, a and c are not necessarily similar.
     * 
     * https://leetcode.com/problems/sentence-similarity/
     */
    public class Solution
    {
        public bool AreSentencesSimilar(string[] sentence1, string[] sentence2, IList<IList<string>> similarPairs)
        {
            if (sentence1.Length != sentence2.Length)
            {
                return false;
            }

            var dict = new Dictionary<string, string>();

            for (var i = 0; i < similarPairs.Count; i++)
            {
                dict.Add(similarPairs[i][0], similarPairs[i][1]);
            }

            for (var i = 0; i < sentence1.Length; i++)
            {
                if (sentence1[i] == sentence2[i])
                {
                    continue;
                }


                if (dict.ContainsKey(sentence1[i]))
                {
                    if (dict[sentence1[i]] == sentence2[i])
                    {
                        continue;
                    }
                }

                if (dict.ContainsKey(sentence2[i]))
                {
                    if (dict[sentence2[i]] == sentence1[i])
                    {
                        continue;
                    }
                }

                return false;
            }

            return true;
        }
    }
}
