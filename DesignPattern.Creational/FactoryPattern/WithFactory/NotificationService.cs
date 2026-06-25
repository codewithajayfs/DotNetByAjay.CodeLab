using DesignPattern.Creational.FactoryPattern.WithFactory.Factory;

namespace DesignPattern.Creational.FactoryPattern.WithFactory
{
    public class NotificationService
    {
        public void SendNotification(string type, string message)
        {
            var notification = NotificationFactory.CreateNotification(type);

            notification.Send(message);
        }
    }
}