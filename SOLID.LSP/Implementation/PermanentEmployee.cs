using SOLID.LSP.Abstract;
using SOLID.LSP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.Implementation
{
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        {

        }
        public PermanentEmployee(int id, string name) : base(id, name)
        {

        }
        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * .1M);
        }

        public override decimal GetMinimumSalary()
        {
            return 15000;
        }
    }
}
