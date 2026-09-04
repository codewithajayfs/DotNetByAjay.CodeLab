namespace LeetCode_P13_RomanToInt;

class Program
{
    /// <summary>
    /// Leet Code 13 - Roman to Integer
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        string input1 = "III";
        Console.WriteLine(RomanToInt(input1));

        string input2 = "LVIII";
        Console.WriteLine(RomanToInt(input2));

        string input3 = "MCMXCIV";
        Console.WriteLine(RomanToInt(input3));
    }

    public static int RomanToInt(string s)
    {
        Dictionary<Char, int> RomanValues = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

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
        result += RomanValues[s[^1]];
        return result;
    }
}
