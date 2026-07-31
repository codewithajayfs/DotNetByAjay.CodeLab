using Microsoft.Extensions.DependencyInjection;
using DesignPattern.StrategyPattern.StrategySelection;
using DesignPattern.StrategyPattern.StrategyInterface;
using DesignPattern.StrategyPattern.ShippingMethods;
using Microsoft.Extensions.Hosting;

namespace DesignPattern.StrategyPattern;

class Program
{
    static void Main(string[] args)
    {
        var host = BuildHost(args);

        var calculator = host.Services.GetRequiredService<ShippingCalculator>();
        var orderAmount = 100;

        var freeShippingCost = calculator.CalculateShipping("Free", orderAmount);
        var localShippingCost = calculator.CalculateShipping("Local", orderAmount);
        var worldwideShippingCost = calculator.CalculateShipping("Worldwide", orderAmount);

        PrintDetails("Free", orderAmount, freeShippingCost);
        PrintDetails("Local", orderAmount, localShippingCost);
        PrintDetails("Worldwide", orderAmount, worldwideShippingCost);
    }

    static void PrintDetails(string shippingMethod, decimal orderAmount, decimal shippingCost)
    {
        Console.WriteLine("{0} Shipping Details", shippingMethod);
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Order Amount: {0}", orderAmount);
        Console.WriteLine("Shipping Cost: {0}", shippingCost);
        Console.WriteLine("\n\n");
    }

    static IHost BuildHost(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);

        builder.Services.AddScoped<IShippingMethod, FreeShipping>();
        builder.Services.AddScoped<IShippingMethod, LocalShipping>();
        builder.Services.AddScoped<IShippingMethod, WorldwideShipping>();

        builder.Services.AddScoped<ShippingCalculator>();

        return builder.Build();
    }

}
