using System.Text;

namespace Console.CSharpProgram;

class Program
{
    static void Main(string[] args)
    {
        string input = "AJAY GANGWAR";
        ReverseStrings reverse = new ReverseStrings();
        
        System.Console.WriteLine($"Input   : {input}");
        System.Console.WriteLine($"Output  : {reverse.ReverseWordWithSpace(input)}");
    }
}
