using System;

namespace Module7.OOP.Homework.Deliveries;

public class PickPointDelivery : Delivery
{
    private string[] addresses;
    
    public PickPointDelivery()
    {
        Console.WriteLine("\nАдреса пунктов выдачи для доставки:");
        
        addresses = new string[]
        {
            "Ленинский проспект, 130а",
            "Генерала Лизюкова, 50",
            "Хользунова, 48а"
        };
        
        for (var i = 0; i < addresses.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {addresses[i]}");
        }
        
        Console.Write("\nВыберите пункт выдачи: ");
        Address = addresses[int.Parse(Console.ReadLine()) - 1];
    }
    
    public override string GetDetails()
    {
        return $"В пункт выдачи по адресу: {Address}";
    }
}