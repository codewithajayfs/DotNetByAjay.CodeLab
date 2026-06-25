# Factory Design Pattern

## What is the Factory Design Pattern?

The Factory Design Pattern is a **Creational Design Pattern** that provides a centralized way to create objects without exposing the object creation logic to the client.

Instead of creating objects directly using the `new` keyword, the client requests the Factory to create the required object.

> **Simple Definition:**  
> "Don't ask the client to create objects. Ask a Factory to create them."

---

# Problem Statement

Imagine you're building a Notification Service.

Initially, the application supports only three notification types:

- Email
- SMS
- Push Notification

A developer writes the following code:

```csharp
if(type == "Email")
{
    var notification = new EmailNotification();
}
else if(type == "SMS")
{
    var notification = new SmsNotification();
}
else if(type == "Push")
{
    var notification = new PushNotification();
}
```

This works perfectly...

But after a few months, the business team asks for:

- WhatsApp Notification
- Slack Notification
- Microsoft Teams Notification
- Telegram Notification

Now, every time a new notification type is introduced, we must modify the existing code.

This makes the code difficult to maintain and violates important design principles.

---

# What is the Problem Here?

The `NotificationService` has two responsibilities:

1. It contains business logic.
2. It decides which object to create.

This creates **tight coupling** between the service and the concrete classes.

Every new notification type forces us to modify the existing class.

---

# Solution

Move the object creation logic into a separate class called **Factory**.

Instead of writing:

```csharp
new EmailNotification();
```

we simply write:

```csharp
NotificationFactory.CreateNotification(type);
```

Now the business logic doesn't care which concrete class gets instantiated.

The Factory takes care of creating the appropriate object.

---

# Without Factory Pattern

```
NotificationService
        │
        ├── new EmailNotification()
        ├── new SmsNotification()
        └── new PushNotification()
```

### Problems

- Tight Coupling
- Multiple `new` statements
- Difficult to maintain
- Violates Open/Closed Principle
- Difficult to extend

---

# With Factory Pattern

```
NotificationService
        │
        ▼
NotificationFactory
        │
        ├── EmailNotification
        ├── SmsNotification
        └── PushNotification
```

### Benefits

- Loose Coupling
- Centralized Object Creation
- Easier to maintain
- Easier to extend
- Cleaner business logic

---

# Components of Factory Pattern

## 1. Product

Defines a common interface.

Example:

```csharp
INotification
```

---

## 2. Concrete Products

Actual implementations of the interface.

Examples:

- EmailNotification
- SmsNotification
- PushNotification

---

## 3. Factory

Responsible for creating objects.

Example:

```csharp
NotificationFactory
```

---

## 4. Client

Uses the Factory to obtain objects.

Example:

```csharp
NotificationService
```

---

# Flow Diagram

```
Client
   │
   ▼
NotificationService
   │
   ▼
NotificationFactory
   │
   ├── EmailNotification
   ├── SmsNotification
   └── PushNotification
```

---

# Advantages

## 1. Loose Coupling

The client doesn't know which concrete class is being instantiated.

---

## 2. Single Responsibility Principle (SRP)

The NotificationService focuses only on sending notifications.

The Factory focuses only on creating objects.

---

## 3. Open/Closed Principle (OCP)

When a new notification type is added, we create a new class.

The business logic remains unchanged.

---

## 4. Centralized Object Creation

All object creation logic is maintained in one place.

---

## 5. Better Readability

Business logic becomes clean and easier to understand.

---

# Disadvantages

- Adds one extra class.
- May increase the number of classes in the project.
- Not useful for very simple applications with only one implementation.

---

# Real-Time Examples

## Notification Service

- Email
- SMS
- Push
- WhatsApp

---

## Payment Gateway

- Razorpay
- Stripe
- PayPal

---

## Logger

- File Logger
- Database Logger
- Console Logger

---

## Database Provider

- SQL Server
- Oracle
- PostgreSQL

---

## Cloud Storage

- Azure Blob Storage
- AWS S3
- Google Cloud Storage

---

## Report Export

- PDF
- Excel
- CSV
- Word

---

# SOLID Principles Followed

## Single Responsibility Principle (SRP)

The Factory creates objects.

The Service performs business operations.

---

## Open/Closed Principle (OCP)

New notification types can be added without modifying the business logic.

---

## Dependency Inversion Principle (DIP)

The client depends on the abstraction (`INotification`) instead of concrete implementations.

---

# Before vs After

| Without Factory | With Factory |
|-----------------|-------------|
| Client creates objects | Factory creates objects |
| Tight Coupling | Loose Coupling |
| Multiple `new` statements | Single Factory |
| Difficult to extend | Easy to extend |
| Business logic knows implementation | Business logic knows only interface |

---

# Interview Questions

## Q1. What is the Factory Design Pattern?

A Factory Design Pattern is a Creational Design Pattern that centralizes object creation and hides the object creation logic from the client.

---

## Q2. Why do we use Factory Pattern?

To reduce tight coupling and centralize object creation.

---

## Q3. Which SOLID principles does Factory Pattern follow?

- Single Responsibility Principle
- Open/Closed Principle
- Dependency Inversion Principle

---

## Q4. What problem does Factory Pattern solve?

It separates business logic from object creation logic.

---

## Q5. When should we use Factory Pattern?

Use Factory Pattern when:

- Multiple implementations exist.
- Object creation depends on runtime input.
- Business logic should not know concrete classes.
- New implementations are added frequently.

---

# Key Takeaways

- Factory Pattern is a **Creational Design Pattern**.
- It centralizes object creation.
- It hides the instantiation logic from the client.
- It promotes loose coupling.
- It improves maintainability and scalability.
- The client should focus on **using objects**, not **creating them**.

> **Rule of Thumb:**  
> If your business logic contains multiple `new` statements based on conditions (`if`, `switch`), consider using the Factory Design Pattern.