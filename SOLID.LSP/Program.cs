using SOLID.LSP.Abstract;
using SOLID.LSP.Implementation;
using SOLID.LSP.Interface;

Console.WriteLine("\n\nGood Example");
// Good Example
List<Employee> employees = new List<Employee>();
employees.Add(new PermanentEmployee(1, "John"));
employees.Add(new TemporaryEmployee(2, "Jason"));
//employees.Add(new ContractEmployee(3, "Mike"));

foreach (var employee in employees)
{
    Console.WriteLine(string.Format("Employee {0} Bonus: {1} Min Salary: {2}",
        employee.ToString(),
        employee.CalculateBonus(10000).ToString(),
        employee.GetMinimumSalary().ToString()));
}

Console.WriteLine("\n\n");
List<IEmployee> employeesOnly = new List<IEmployee>();
employeesOnly.Add(new PermanentEmployee(1, "John"));
employeesOnly.Add(new TemporaryEmployee(2, "Jason"));
employeesOnly.Add(new ContractEmployee(3, "Mike"));

foreach (var employee in employeesOnly)
{
    Console.WriteLine(string.Format("Employee {0} Bonus : {1}",
        employee.ToString(),
        employee.GetMinimumSalary().ToString()));
}