using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.CSharpProgram
{
    public class ReverseStrings
    {
        public string ReverseWordWithSpace(string input)
        {

            string[] words = input.Split();
            StringBuilder output = new();

            foreach (string word in words)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    output.Append(word[i]);
                }
                output.Append(' ');
            }

            return output.ToString().TrimEnd();
        }
    }
}