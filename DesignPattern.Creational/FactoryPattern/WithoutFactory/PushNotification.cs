namespace DesignPattern.Creational.FactoryPattern.WithoutFactory
{
    public class PushNotification
    {
        public void Send(string message)
    {
        Console.WriteLine($"🔔 Push Notification : {message}");
    }
    }
}