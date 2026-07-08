using SOLID.LSP.Abstract;
using SOLID.LSP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.Implementation
{


    public class ContractEmployee : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ContractEmployee()
        {

        }
        public ContractEmployee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public decimal GetMinimumSalary()
        {
            return 5000;
        }
        public override string ToString()
        {
            return string.Format("Id: {0} Name : {1}", this.Id, this.Name);
        }
    }
}
