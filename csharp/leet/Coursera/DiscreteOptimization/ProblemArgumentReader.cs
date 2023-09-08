using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet.Coursera.DiscreteOptimization
{
    public static class ProblemArgumentReader
    {
        public static List<int[]> ReadInts(string path)
        {
            var list = new List<int[]>();
            if(!File.Exists(path))
            {
                throw new ArgumentException($"Could not find file {path}.");
            }

            var lines = File.ReadAllLines(path);

            for (var i = 0; i < lines.Length; ++i)
            {
                var words = lines[i].Split(" ");
                var arr = new int[words.Length];

                for(var k = 0; k < words.Length; ++k)
                {
                    arr[k] = int.Parse(words[k]);
                }

                list.Add(arr);
            }

            return list;
        }
    }
}
