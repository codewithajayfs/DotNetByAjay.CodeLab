namespace DesignPattern.Creational.FactoryPattern.WithoutFactory
{
    public class SmsNotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"📱 SMS Sent : {message}");
        }
    }
}