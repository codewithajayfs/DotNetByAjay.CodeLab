using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.BadExample
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmployeeType { get; set; }

        public Employee()
        {

        }
        public Employee(int id, string name, string employeeType)
        {
            this.Id = id;
            this.Name = name;
            this.EmployeeType = employeeType;
        }

        public decimal CalculateBonus(decimal salary)
        {
            if (this.EmployeeType == "Permanent")
                return salary * .1M;
            else
                return salary * .05M;

        }

        public override string ToString()
        {
            return string.Format("Id : {0} Name : {1}", this.Id, this.Name);
        }
    }
}
