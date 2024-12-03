using System.Collections.Generic;

namespace Module7.OOP.Homework;

public class Product
{
    public string Name { get; }
    public string Category { get; }
    public int Price { get; }
    public List<Review> Reviews { get; }
    public double Rating => GetAverageRating();

    public Product(string name, string category, int price)
    {
        Name = name;
        Category = category;
        Price = price;
        Reviews = new List<Review>();
    }

    private double GetAverageRating()
    {
        double totalRating = 0;
        
        if (Reviews.Count == 0)
            return 0;

        foreach (var review in Reviews)
        {
            totalRating += review.Rating;
        }
        
        return totalRating / Reviews.Count;
    }
}