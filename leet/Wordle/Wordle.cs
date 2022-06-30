using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace leet.Wordle
{
   /* public class Wordle
    {
        private string[] remainingWordlist;
        public string[] Solve(char[] solved, char[] contains, char[] notContain)
        {

        }

        private List<string> Possibilities(char[] solved, char[] contains, char[] notContain)
        {
            //Check solved

            //Check contains

            //Check notContains

        }

        private bool Solved()
        {

        }


        private string Recomendation(List<string> possibilities)
        {
            if (possibilities.Count < 1)
            {
                throw new InvalidOperationException("Cannot provide a recommendation if possibilities list is empty.");
            }
            
            var letterList = GetAlphabetDictionary();
            var highword = String.Empty;
            var highscore = 0;

            foreach(var entry in possibilities)
            {
                foreach(char let in entry)
                {
                    letterList[let]++;
                }
            }

            foreach(var entry in possibilities)
            {
                var score = 0;

                foreach(char let in entry)
                {
                    score += letterList[let];
                }

                if (score > highscore)
                {
                    highscore = score;
                    highword = entry;
                }
            }

            return highword;
        }

        private Dictionary<char, int> GetAlphabetDictionary()
        {
            return new Dictionary<char, int>()
            {
                { 'a', 0 },
                { 'b', 0 },
                { 'c', 0 },
                { 'd', 0 },
                { 'e', 0 },
                { 'f', 0 },
                { 'g', 0 },
                { 'h', 0 },
                { 'i', 0 },
                { 'j', 0 },
                { 'k', 0 },
                { 'l', 0 },
                { 'm', 0 },
                { 'n', 0 },
                { 'o', 0 },
                { 'p', 0 },
                { 'q', 0 },
                { 'r', 0 },
                { 's', 0 },
                { 't', 0 },
                { 'u', 0 },
                { 'v', 0 },
                { 'w', 0 },
                { 'x', 0 },
                { 'y', 0 },
                { 'z', 0 },
            };
        }
    }*/
}
