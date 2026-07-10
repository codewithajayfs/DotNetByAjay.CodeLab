
using Console.CSharp12;

System.Console.WriteLine("Hello, World!");

// Primary Constructor - Bad Example
System.Console.WriteLine("\nPrimary Constructor - Bad Example");
var employee = new Employee("John Doe", 30);
employee.DisplayInfo();

// Primary Constructor - Good Example
System.Console.WriteLine("\nPrimary Constructor - Good Example");
var employee2 = new EmployeePrimaryConstructor("Jane Smith", 25);
employee2.DisplayInfo();

// Primary Constructor - Good Example with Properties
System.Console.WriteLine("\nPrimary Constructor - Good Example with Properties");
var employee3 = new EmployeePrimaryConstructor1("Alice Johnson", 28);
employee3.DisplayInfo();