// using DesignPattern.Creational.FactoryPattern.WithoutFactory;

// Console.WriteLine("\nWITHOUT FACTORY PATTERN");
// Console.WriteLine("-----------------------");

// NotificationService notificationService = new();

// notificationService.SendNotification("Email", "Welcome Ajay!");
// notificationService.SendNotification("SMS", "OTP : 123456");
// notificationService.SendNotification("Push", "Your order has been shipped.");

// // Testing
// Console.WriteLine("\n\n-----Unit Testing-----");
// notificationService.SendNotification("Email", "Hello");
// notificationService.SendNotification("SMS", "OTP");
// notificationService.SendNotification("Push", "Order Delivered");
// notificationService.SendNotification("ABC", "Test");


// Console.WriteLine("\n\nWITH FACTORY PATTERN");
// Console.WriteLine("--------------------");

// NotificationService _notificationService = new();

// _notificationService.SendNotification("Email", "Welcome Ajay!");
// _notificationService.SendNotification("SMS", "OTP : 123456");
// _notificationService.SendNotification("Push", "Your order has been shipped.");

// // Testing
// Console.WriteLine("\n\n-----Unit Testing-----");
// _notificationService.SendNotification("Email", "Hello");
// _notificationService.SendNotification("SMS", "OTP");
// _notificationService.SendNotification("Push", "Order Delivered");
// try
// {
//     notificationService.SendNotification("ABC", "Test");
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine(ex.Message);
// }

// using DesignPattern.Creational.Singleton.ThreadSafe;
// using DesignPattern.Creational.Singleton.EagerLoading;


// Singleton - Thread safe
using WithoutSingleton = DesignPattern.Creational.Singleton.WithoutSingleton;
using WithSingleton = DesignPattern.Creational.Singleton.WithSingleton;
using ThreadSafe = DesignPattern.Creational.Singleton.ThreadSafe;
using EagerLoading = DesignPattern.Creational.Singleton.EagerLoading;
using LazyLoading = DesignPattern.Creational.Singleton.LazyLoading;

Console.WriteLine("\nSINGLETON DESIGN PATTERN");
Console.WriteLine("-----------Without Singleton------------");

var singletonMessage = new WithoutSingleton.Singleton();
singletonMessage.PrintDetails("This is first message");
singletonMessage.PrintDetails("This is second message");

var fromEmployee = new WithoutSingleton.Singleton();
fromEmployee.PrintDetails("From Employee");

var fromStudent = new WithoutSingleton.Singleton();
fromStudent.PrintDetails("From Student");

Console.WriteLine("\n\n-----------With Singleton------------");
/*
// Assuming Singleton is created from Student class
// We refer to the GetInstance property from the Singleton class
*/
var fromSingletonStudent = WithSingleton.Singleton.GetInstance;
fromSingletonStudent.PrintDetails("From Student");

/*
// Assuming Singleton is created from Employee class
// We refer to the GetInstance property from the Singleton class
*/
var fromSingletonEmployee = WithSingleton.Singleton.GetInstance;
fromSingletonEmployee.PrintDetails("From Employee");


// Create object using Drive class, when class is not Singleton
// Console.WriteLine("-----------With Singleton: Drive Class------------");
// WithSingleton.Singleton.DriveSingleton driveObject = new WithSingleton.Singleton.DriveSingleton();
// driveObject.PrintDetails("From Drive");

Console.WriteLine("\n\n-----------Thread Safe------------");
Parallel.Invoke(
    () => PrintStudentDetails(),
    () => PrintEmployeeDetails()
);

static void PrintStudentDetails()
{
    var fromStudent = ThreadSafe.Singleton.GetInstance;
    fromStudent.PrintDetails("From ThreadSafe Student");
}

static void PrintEmployeeDetails()
{
    var fromEmployee = ThreadSafe.Singleton.GetInstance;
    fromEmployee.PrintDetails("From ThreadSafe Employee");
}

Console.WriteLine("\n\n-----------Eager Loading------------");
Parallel.Invoke(
    () => PrintEagerStudentDetails(),
    () => PrintEagerEmployeeDetails()
);

static void PrintEagerStudentDetails()
{
    var fromStudent = EagerLoading.Singleton.GetInstance;
    fromStudent.PrintDetails("From Eager Student");
}

static void PrintEagerEmployeeDetails()
{
    var fromEmployee = EagerLoading.Singleton.GetInstance;
    fromEmployee.PrintDetails("From Eager Employee");
}

Console.WriteLine("\n\n-----------Lazy Loading------------");
Parallel.Invoke(
    () => PrintLazyStudentDetails(),
    () => PrintLazyEmployeeDetails()
);

static void PrintLazyStudentDetails()
{
    var fromStudent = LazyLoading.Singleton.GetInstance;
    fromStudent.PrintDetails("From Eager Student");
}

static void PrintLazyEmployeeDetails()
{
    var fromEmployee = LazyLoading.Singleton.GetInstance;
    fromEmployee.PrintDetails("From Eager Employee");
}