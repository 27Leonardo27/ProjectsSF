using System;
using System.Collections.Generic;
using Module7.OOP.Homework.Deliveries;
using Module7.OOP.Homework.Extensions;
using Module7.OOP.Homework.Orders;

namespace Module7.OOP.Homework;

public class Program
{
    private static User[] users;

    private static Product[] products;
    private static OrderBase[] orders;
    
    public static void Main(string[] args)
    {
        users = new[]
        {
            new User("Андрей", "ул. Пушкина 13", "+7 228 123 33 22"),
            new User("Дмитрий", "ул. Пилоткина 228", "+7 800 555 35 35")
        };

        products = new[]
        {
            new Product("iPhone 15", "Smartphone", 100000),
            new Product("Samsung Galaxy S24", "Smartphone", 100000),
            new Product("PlayStation 5", "Gaming Console", 60000)
        };

        do
        {
            Console.WriteLine("\n1 - Создать заказ");
            Console.WriteLine("2 - Оставить отзыв");
            Console.WriteLine("3 - Отзывы о товаре");
            Console.WriteLine("4 - Заказы пользователя");
            Console.WriteLine("5 - Выход");
            
            Console.Write("\nВыберите действие: ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateOrder();
                    break;
                case "2":
                    CreateReview();
                    break;
                case "3":
                    PrintReviews();
                    break;
                case "4":
                    PrintUserOrders();
                    break;
                case "5":
                    return;
            }
        } while (true);
    }

    private static void PrintUserOrders()
    {
        var user = PickUser();
        User.PrintOrders(user);
    }

    private static void CreateReview()
    {
        var user = PickUser();
        var product = PickProduct();
        
        Console.Write("\nВведите оценку 1-5: ");
        var rating = Console.ReadLine();
        
        Console.Write("Введите текст отзыва: ");
        var text = Console.ReadLine();
        
        user.AddReview(product, text, int.Parse(rating));
    }

    private static void PrintReviews()
    {
        var product = PickProduct();
        product.PrintReviews();
    }

    private static Product PickProduct()
    {
        Console.WriteLine();
        
        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {products[i].Name}");
        }
        
        Console.Write("Выберите номер товара: ");
        var product = products[int.Parse(Console.ReadLine()) - 1];
        
        return product;
    }

    private static User PickUser()
    {
        Console.WriteLine();
        
        for (int i = 0; i < users.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {users[i].Name}");
        }
        
        Console.Write("\nВыберите пользователя: ");
        var user = users[int.Parse(Console.ReadLine()) - 1];
        
        return user;
    }
    
    private static List<Product> PickProducts()
    {
        var result = new List<Product>();

        do
        {
            Console.WriteLine();
            
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {products[i].Name}");
            }
        
            Console.Write("Выберите номер товара или '0' для выхода: ");
            var input = int.Parse(Console.ReadLine());
            
            if (input == 0)
                return result;

            result.Add(products[input - 1]);
        } while (true);
    }

    private static void CreateOrder()
    {
        var user = PickUser();
        var products = PickProducts();

        Console.WriteLine("\n1 - Доставка в магазин");
        Console.WriteLine("2 - Доставка в пункт выдачи");
        Console.WriteLine("3 - Доставка на дом");
        
        Console.Write("\nВыберите способ доставки: ");
        var input = Console.ReadLine();

        Delivery delivery;
        
        switch (input)
        {
            case "1":
                delivery = new ShopDelivery();
                break;
            case "2":
                delivery = new PickPointDelivery();
                break;
            case "3":
                delivery = new HomeDelivery(user.Address);
                break;
            default:
                delivery = new ShopDelivery();
                break;
        }

        var order = user.CreateOrder(delivery, products.ToArray());

        Console.WriteLine("\nЗаказ успешно создан!");
        
        order.PrintDetails();
    }
}