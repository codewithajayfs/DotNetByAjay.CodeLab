using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.Interface
{
    public interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal GetMinimumSalary();
    }
}
