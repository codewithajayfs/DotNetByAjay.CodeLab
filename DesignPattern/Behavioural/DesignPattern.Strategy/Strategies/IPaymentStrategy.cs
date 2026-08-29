using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.Strategies
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}