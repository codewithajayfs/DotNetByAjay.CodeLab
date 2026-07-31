using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.StrategyPattern.StrategyInterface
{
    public interface IShippingMethod
    {
        string ShippingMethod { get; }
        decimal Calculate(decimal orderAmount);
    }
}