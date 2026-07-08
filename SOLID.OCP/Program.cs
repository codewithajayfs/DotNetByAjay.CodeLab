using BadExample = SOLID.OCP.BadExample;
using GoodExample = SOLID.OCP.GoodExample;


// OCP is voilating here, We have changed the method to support the new requirement
BadExample.Employee empJohn = new BadExample.Employee(1, "John", "Permanent");
BadExample.Employee empJason = new BadExample.Employee(2, "Jason", "Temporary");

Console.WriteLine("Bad Example");
Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
    empJohn.ToString(),
    empJohn.CalculateBonus(10000).ToString()));

Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
    empJason.ToString(),
    empJason.CalculateBonus(15000).ToString()));


Console.WriteLine("\n\nGood Example");
// Good Example
GoodExample.Employee empJohn1 = new GoodExample.PermanentEmployee(1, "John");
GoodExample.Employee empJason1 = new GoodExample.TemporaryEmployee(2, "Jason");

Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
    empJohn1.ToString(),
    empJohn1.CalculateBonus(10000).ToString()));

Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
    empJason1.ToString(),
    empJason1.CalculateBonus(15000).ToString()));

Console.ReadLine();