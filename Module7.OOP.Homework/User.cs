using System;
using System.Collections.Generic;
using Module7.OOP.Homework.Deliveries;
using Module7.OOP.Homework.Extensions;
using Module7.OOP.Homework.Orders;

namespace Module7.OOP.Homework;

public class User
{
    public string Name { get; }
    public string Address { get; }
    public string PhoneNumber { get; }
    
    protected List<OrderBase> Orders { get; }

    public User(string name, string address, string phoneNumber)
    {
        Name = name;
        Address = address;
        PhoneNumber = phoneNumber;
        Orders = new List<OrderBase>();
    }
    
    public void AddReview(Product product, string text, int rating)
    {
        var review = new Review(this, text, rating);
        product.Reviews.Add(review);
    }

    public Order<TDelivery> CreateOrder<TDelivery>(TDelivery delivery, params Product[] products)
        where TDelivery : Delivery
    {
        var order = new Order<TDelivery>(this, delivery, products);
        
        Orders.Add(order);
        
        return order;
    }

    public static void PrintOrders(User user)
    {
        if (user.Orders.Count == 0)
        {
            Console.WriteLine($"\nУ пользователя {user.Name} еще нет заказов");
            return;
        }
        
        foreach (var order in user.Orders)
        {
            order.PrintDetails();
        }
    }
}