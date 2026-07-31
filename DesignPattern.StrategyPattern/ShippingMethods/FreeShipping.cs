using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.StrategyPattern.StrategyInterface;

namespace DesignPattern.StrategyPattern.ShippingMethods
{
    public class FreeShipping : IShippingMethod
    {
        public string ShippingMethod => "Free";

        public decimal Calculate(decimal orderAmount)
        {
            return 0;
        }
    }
}