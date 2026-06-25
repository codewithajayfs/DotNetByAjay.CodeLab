using DesignPattern.Creational.FactoryPattern.WithFactory.Interfaces;

namespace DesignPattern.Creational.FactoryPattern.WithFactory.Notifications
{
    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"🔔 Push Notification : {message}");
        }
    }
}