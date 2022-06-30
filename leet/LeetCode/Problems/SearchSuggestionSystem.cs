using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Problems.SearchSuggestionSystem
{
    public class Solution
    {
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            var result = new List<IList<string>>();
            var remainingProduct = new List<string>();

            foreach(var product in products)
            {
                remainingProduct.Add(product);
            }
            remainingProduct.Sort();

            var i = 0;
            while( i < searchWord.Length)
            {
                var answers = new List<string>();
                var removes = new List<string>();

                foreach(var product in remainingProduct)
                {
                    if (i >= product.Length || searchWord[i] != product[i])
                    {
                        removes.Add(product);
                    }
                    else if(answers.Count < 3)
                    {
                        answers.Add(product);
                    }
                }

                foreach(var product in removes)
                {
                    remainingProduct.Remove(product);
                }

                result.Add(answers);

                ++i;
            }

            return result;
        }
    }
}
