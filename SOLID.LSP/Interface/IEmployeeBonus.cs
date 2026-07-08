using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.Interface
{
    public interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);
    }
}
