using System;

public class OrderProcessor
{
    public delegate void OrderPlacedHandler(Order order);

    public event OrderPlacedHandler OnOrderPlaced;

    public void ProcessOrder(Order order)
    {
        Console.WriteLine($"Order Placed: {order.OrderId}");

        OnOrderPlaced?.Invoke(order);
    }
}