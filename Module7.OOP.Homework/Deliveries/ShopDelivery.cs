using System;

namespace Module7.OOP.Homework.Deliveries;

public class ShopDelivery : Delivery
{
    private string[] addresses;

    public ShopDelivery()
    {
        Console.WriteLine("\nАдреса магазинов для доставки:");
        
        addresses = new string[]
        {
            "Кольцовская улица, 35",
            "Ленинский проспект, 174п",
            "Димитрова, 67а"
        };
        
        for (var i = 0; i < addresses.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {addresses[i]}");
        }
        
        Console.Write("\nВыберите магазин: ");
        Address = addresses[int.Parse(Console.ReadLine()) - 1];
    }
    
    public override string GetDetails()
    {
        return $"В магазин по адресу: {Address}";
    }
}