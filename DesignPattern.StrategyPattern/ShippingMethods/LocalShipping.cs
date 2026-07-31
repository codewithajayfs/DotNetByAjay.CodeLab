using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.StrategyPattern.StrategyInterface;

namespace DesignPattern.StrategyPattern.ShippingMethods
{
    public class LocalShipping : IShippingMethod
    {
        public string ShippingMethod => "Local";

        public decimal Calculate(decimal orderAmount)
        {
            return orderAmount * 0.15m;
        }
    }
}