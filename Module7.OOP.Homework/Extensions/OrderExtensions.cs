using System;
using Module7.OOP.Homework.Orders;

namespace Module7.OOP.Homework.Extensions;

public static class OrderExtensions
{
    public static void PrintDetails(this OrderBase order)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\n===============================");
        Console.WriteLine($"Заказ пользователя {order.User.Name}");

        Console.WriteLine("\nИнформация о доставке:");
        Console.WriteLine(order.GetDeliveryDetails());

        Console.WriteLine("\nСписок товаров:");
        foreach (var product in order.Products)
        {
            Console.WriteLine($"  - {product.Name}: {product.Price}р.");
        }
        
        Console.WriteLine($"\nСтатус заказа: {order.GetStatus()}");
        Console.WriteLine($"Итоговая цена: {order.TotalPrice}p.");
        Console.WriteLine("===============================\n");
        Console.ResetColor();
    }
}