using DesignPattern.Creational.FactoryPattern.WithFactory.Interfaces;

namespace DesignPattern.Creational.FactoryPattern.WithFactory.Notifications
{
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"📧 Email Sent : {message}");
        }
    }
}