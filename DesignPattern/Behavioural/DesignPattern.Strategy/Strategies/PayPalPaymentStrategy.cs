using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.Strategies
{
    public class PayPalPaymentStrategy : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            
            Console.WriteLine($"Paid ₹{amount} using PayPal.");
        }
    }
}