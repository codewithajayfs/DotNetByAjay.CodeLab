using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Console.CSharpProgram
{
    public abstract class BaseClass
    {
        public abstract void Display();
    }
    public class DriveClass : BaseClass
    {
        public override void Display()
        {
            System.Console.WriteLine("Drive Class");
        }
    }

}