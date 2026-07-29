using System.Text;

namespace Console.CSharpProgram;

class Program
{
    static void Main(string[] args)
    {
        // ReverseStrings reverse = new ReverseStrings();
        // string input = "AJAY GANGWAR";

        // System.Console.WriteLine("Reverse Entire String using Array.Reverse");
        // System.Console.WriteLine($"Input   : {input}");
        // System.Console.WriteLine($"Output  : {reverse.ReverseStringUsingBuiltInFunction(input)}");
        // System.Console.WriteLine();


        // System.Console.WriteLine("Reverse Entire String");
        // System.Console.WriteLine($"Input   : {input}");
        // System.Console.WriteLine($"Output  : {reverse.ReverseEntireString(input)}");
        // System.Console.WriteLine();


        // System.Console.WriteLine("Reverse words while preserving spaces");
        // System.Console.WriteLine($"Input   : {input}");
        // System.Console.WriteLine($"Output  : {reverse.ReverseWordWithSpace(input)}");
        // System.Console.WriteLine();

        // Checking string is Palindrome
        // string inputString = "MADAM";
        // System.Console.WriteLine(inputString.IsPalindrome());

        //Char count in the string
        // string inputString1 = "Hello, how are you?";
        // OccuranceOfCharInString charInString = new OccuranceOfCharInString();
        // charInString.CharOccurance(inputString1);

        // Missing number in array
        int[] inputArray = { 3, 0, 1 };
        int[] inputArray1 = [0, 1];
        int[] inputArray2 = [9, 6, 4, 2, 3, 5, 7, 0, 1];
        int[] inputArray3 = [1];
        Program_FindMissingNumber findMissingNumber = new Program_FindMissingNumber();
        System.Console.WriteLine($"Missing number is - {findMissingNumber.MissingNumber(inputArray)}");
        System.Console.WriteLine($"Missing number is - {findMissingNumber.MissingNumber(inputArray1)}");
        System.Console.WriteLine($"Missing number is - {findMissingNumber.MissingNumber(inputArray2)}");
        System.Console.WriteLine($"Missing number is - {findMissingNumber.MissingNumber(inputArray3)}");
    }
}
