namespace CSharpBasic._01_Constants;

class Program
{
    public const double Rate = 5.0;
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Interest Calculator");

        Console.WriteLine("Enter the principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the number of years: ");
        double time = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = (principal * time * Rate) / 100;
        Console.WriteLine("Simple Interest: " + simpleInterest);
    }
}
