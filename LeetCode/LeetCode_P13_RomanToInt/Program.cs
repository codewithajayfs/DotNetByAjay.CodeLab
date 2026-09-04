namespace LeetCode_P13_RomanToInt;

class Program
{
    private static readonly Dictionary<char, int> RomanValues = new()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

    /// <summary>
    /// Leet Code 13 - Roman to Integer
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        string input1 = "III";
        Console.WriteLine(RomanToInt1(input1));
        Console.WriteLine(RomanToInt2(input1));
        Console.WriteLine(RomanToInt3(input1));

        string input2 = "LVIII";
        Console.WriteLine(RomanToInt1(input2));
        Console.WriteLine(RomanToInt2(input2));
        Console.WriteLine(RomanToInt3(input2));

        string input3 = "MCMXCIV";
        Console.WriteLine(RomanToInt1(input3));
        Console.WriteLine(RomanToInt2(input3));
        Console.WriteLine(RomanToInt3(input3));
    }

    /// <summary>
    /// Dictionary approach
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static int RomanToInt1(string s)
    {
        int result = 0;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (RomanValues[s[i]] >= RomanValues[s[i + 1]])
            {
                result += RomanValues[s[i]];
            }
            else
            {
                result -= RomanValues[s[i]];
            }
        }

        result += RomanValues[s[^1]]; // s[s.Length - 1] can be simplified using the C# index-from-end operator: s[^1]

        return result;
    }

    /// <summary>
    /// Switch expression
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static int RomanToInt2(string s)
    {
        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int current = GetValue(s[i]);

            if (i + 1 < s.Length && current < GetValue(s[i + 1]))
            {
                result -= current;
            }
            else
            {
                result += current;
            }
        }

        return result;
    }

    private static int GetValue(char c)
    {
        return c switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0
        };
    }

    /// <summary>
    /// Single-pass with Dictionary
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static int RomanToInt3(string s)
    {
        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int current = RomanValues[s[i]];

            if (i + 1 < s.Length &&
                current < RomanValues[s[i + 1]])
            {
                result -= current;
            }
            else
            {
                result += current;
            }
        }

        return result;
    }
}
