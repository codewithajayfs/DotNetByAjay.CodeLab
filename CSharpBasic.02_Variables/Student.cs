using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpBasic._02_Variables
{
    public class Student
    {
        // Class-level variables (fields)
        public string Name = "Ajay";
        public int Age = 35;

        //Method to display student information
        public void DisplayStudentInfo()
        {
            // Implicitly typed variable
            var salary = 1000;
            // salary = "Thousend"; -- Wrong - Cannot be changed

            //Method-level variable (local variable)
            string message = "This is a student information";
            Console.WriteLine(message); // Correct 
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);

            if (Age >= 18)
            {
                // Block level variable
                string result = "This student is an adult";
                Console.WriteLine(result);
            }
        }

        // Console.WriteLine(message); -- method level variable is not accessable
    }
}