namespace DesignPattern.Creational.FactoryPattern.WithoutFactory
{
    public class EmailNotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"📧 Email Sent : {message}");
        }
    }
}