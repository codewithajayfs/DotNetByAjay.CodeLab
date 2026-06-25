using DesignPattern.Creational.FactoryPattern.WithFactory.Interfaces;

namespace DesignPattern.Creational.FactoryPattern.WithFactory.Notifications
{
    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"📱 SMS Sent : {message}");
        }
    }
}