using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Console.CSharpProgram
{
    public class Program_FindMissingNumber
    {
        public int MissingNumber(int[] input)
        {
            int n = input.Length;

            // Iterate from 1 to n and check
            // if the current number is present
            for (int i = 0; i <= n; i++)
            {
                bool found = false;
                for (int j = 0; j < n; j++)
                {
                    if (input[j] == i)
                    {
                        found = true;
                        break;
                    }
                }

                // If the current number is not present
                if (!found)
                    return i;
            }
            return -1;
        }
    }
}