using DesignPattern.Strategy.Services;
using DesignPattern.Strategy.Strategies;

Console.WriteLine("Hello, Welcome to Payment Service!");

var paymentStrategy = new UpiPaymentStrategy();
var paymentService = new PaymentService(paymentStrategy);

paymentService.ProcessPayment(5000);

