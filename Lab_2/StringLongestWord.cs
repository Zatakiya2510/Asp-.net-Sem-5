using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class StringLongestWord
    {
        public static string FindLongestWord(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            string[] words = input.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();
            return longestWord;
        }
    }
}
