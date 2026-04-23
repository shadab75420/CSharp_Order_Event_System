using System;

class Program
{
    static void Main(string[] args)
    {
        OrderProcessor processor = new OrderProcessor();

        EmailService emailService = new EmailService();
        SMSService smsService = new SMSService();
        LoggerService loggerService = new LoggerService();

        processor.OnOrderPlaced += emailService.SendEmail;
        processor.OnOrderPlaced += smsService.SendSMS;
        processor.OnOrderPlaced += loggerService.LogOrder;

        Order order = new Order
        {
            OrderId = 101,
            CustomerName = "Shadab",
            Amount = 5000
        };

        processor.ProcessOrder(order);

        processor.OnOrderPlaced -= smsService.SendSMS;

        Console.WriteLine("\nAfter Unsubscribing SMS:\n");

        processor.ProcessOrder(order);
    }
}