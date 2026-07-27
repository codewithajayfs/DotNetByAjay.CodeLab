using System.Text;

namespace Console.CSharpProgram;

class Program
{
    static void Main(string[] args)
    {
        ReverseStrings reverse = new ReverseStrings();
        string input = "AJAY GANGWAR";

        System.Console.WriteLine("Reverse Entire String using Array.Reverse");
        System.Console.WriteLine($"Input   : {input}");
        System.Console.WriteLine($"Output  : {reverse.ReverseStringUsingBuiltInFunction(input)}");
        System.Console.WriteLine();


        System.Console.WriteLine("Reverse Entire String");
        System.Console.WriteLine($"Input   : {input}");
        System.Console.WriteLine($"Output  : {reverse.ReverseEntireString(input)}");
        System.Console.WriteLine();


        System.Console.WriteLine("Reverse words while preserving spaces");
        System.Console.WriteLine($"Input   : {input}");
        System.Console.WriteLine($"Output  : {reverse.ReverseWordWithSpace(input)}");
        System.Console.WriteLine();
    }
}
