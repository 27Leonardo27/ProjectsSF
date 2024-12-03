using System;

namespace Module7.OOP.Homework.Extensions;

public static class ProductExtensions
{
    public static void PrintReviews(this Product product)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("\n===============================");
        
        Console.WriteLine($"Товар: {product.Name} - Рейтинг: {product.Rating}");
        Console.WriteLine("\nОтзывы:");
        
        foreach (var review in product.Reviews)
        {
            Console.WriteLine($"  {review.User.Name} - Оценка: {review.Rating}");
            Console.WriteLine($"  {review.Text}");
            Console.WriteLine("-------");
        }
        
        Console.WriteLine("===============================\n");
        Console.ResetColor();
    }
}