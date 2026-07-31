using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.StrategyPattern.StrategyInterface;

namespace DesignPattern.StrategyPattern.ShippingMethods
{
    public class WorldwideShipping : IShippingMethod
    {
        public string ShippingMethod => "Worldwide";

        public decimal Calculate(decimal orderAmount)
        {
            return 10;
        }
    }
}