namespace DesignPattern.Creational.FactoryPattern.WithoutFactory
{
    public class NotificationService
    {
        public void SendNotification(string type, string message)
        {
            if(type == "Email")
            {
                var email = new EmailNotification();
                email.Send(message);
            }
            else if (type == "SMS")
            {
                var sms = new SmsNotification();
                sms.Send(message);
            }
            else if(type == "Push")
            {
                var push =  new PushNotification();
                push.Send(message);
            }
            else
            {
                Console.WriteLine("Invalid Notification Type");
            }
        }
    }
}