using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Console.CSharpProgram
{
    public class OccuranceOfCharInString
    {
        public void CharOccurance(string input)
        {
            if (string.IsNullOrEmpty(input)) return;

            input = input.ToLower();
            Dictionary<char, int> dictCharCount = [];

            foreach (char ch in input)
            {
                if (dictCharCount.ContainsKey(ch))
                {
                    dictCharCount[ch]++;
                }
                else
                    dictCharCount[ch] = 1;
            }

            foreach (var pair in dictCharCount)
            {
                System.Console.WriteLine($"The char '{ pair.Key }' occuers '{ pair.Value }'");
            }
        }
    }
}