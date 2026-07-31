using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.StrategyPattern.StrategyInterface;
using Microsoft.VisualBasic;

namespace DesignPattern.StrategyPattern.StrategySelection
{
    public class ShippingCalculator(IEnumerable<IShippingMethod> shippingMethods)
    {
        public decimal CalculateShipping(string shippingMethod, decimal orderAmount)
        {
            var strategy = shippingMethods.Single(x => x.ShippingMethod == shippingMethod);

            return strategy.Calculate(orderAmount);
        }
    }
}