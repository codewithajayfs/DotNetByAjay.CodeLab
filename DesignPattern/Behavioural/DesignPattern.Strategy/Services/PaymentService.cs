using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.Strategy.Strategies;

namespace DesignPattern.Strategy.Services
{
    public class PaymentService
    {
        private readonly IPaymentStrategy _paymentStrategy;
        public PaymentService(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing payment...");
            _paymentStrategy.Pay(amount);
            Console.WriteLine("Payment completed.");
        }
    }
}