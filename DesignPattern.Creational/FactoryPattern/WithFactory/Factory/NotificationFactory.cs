using DesignPattern.Creational.FactoryPattern.WithFactory.Interfaces;
using DesignPattern.Creational.FactoryPattern.WithFactory.Notifications;

namespace DesignPattern.Creational.FactoryPattern.WithFactory.Factory
{
    public static class NotificationFactory
    {
        public static INotification CreateNotification(string type)
        {
            return type.ToUpper() switch
            {
                "EMAIL" => new EmailNotification(),
                "SMS" => new SmsNotification(),
                "PUSH" => new PushNotification(),
                _ => throw new ArgumentException("Invalid Notification Type")
            };
        }
    }
}