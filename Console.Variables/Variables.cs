using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Console.Variables
{
    public class Variables
    {

        public const double PI = 3.14159;
        public const string Name = "Ajay Gangwar";

        public Variables()
        {
            // PI = 3.2343;
            // Name = "Vijay";
        }
        public void DoWork()
        {
            System.Console.WriteLine(PI);
        }
    }
}