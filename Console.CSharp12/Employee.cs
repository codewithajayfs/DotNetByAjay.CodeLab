using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Console.CSharp12
{
    public class Employee
    {
        private string _name;
        private int _age;

        public Employee(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public void DisplayInfo()
        {
            System.Console.WriteLine($"Name: {_name}, Age: {_age}");
        }
    }

    public class EmployeePrimaryConstructor(string name, int age)
    {
        public void DisplayInfo()
        {
            System.Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    public class EmployeePrimaryConstructor1
    {
        public void DisplayInfo()
        {
            System.Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
        public EmployeePrimaryConstructor1(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public string Name { get; }
        public int Age { get; }
    }

}