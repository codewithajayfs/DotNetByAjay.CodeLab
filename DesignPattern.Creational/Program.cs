using DesignPattern.Creational.FactoryPattern.WithoutFactory;

Console.WriteLine("\nWITHOUT FACTORY PATTERN");
Console.WriteLine("-----------------------");

NotificationService notificationService = new();

notificationService.SendNotification("Email", "Welcome Ajay!");
notificationService.SendNotification("SMS", "OTP : 123456");
notificationService.SendNotification("Push", "Your order has been shipped.");

// Testing
Console.WriteLine("\n\n-----Unit Testing-----");
notificationService.SendNotification("Email", "Hello");
notificationService.SendNotification("SMS", "OTP");
notificationService.SendNotification("Push", "Order Delivered");
notificationService.SendNotification("ABC", "Test");


Console.WriteLine("\n\nWITH FACTORY PATTERN");
Console.WriteLine("--------------------");

NotificationService _notificationService = new();

_notificationService.SendNotification("Email", "Welcome Ajay!");
_notificationService.SendNotification("SMS", "OTP : 123456");
_notificationService.SendNotification("Push", "Your order has been shipped.");

// Testing
Console.WriteLine("\n\n-----Unit Testing-----");
_notificationService.SendNotification("Email", "Hello");
_notificationService.SendNotification("SMS", "OTP");
_notificationService.SendNotification("Push", "Order Delivered");
try
{
    notificationService.SendNotification("ABC", "Test");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}