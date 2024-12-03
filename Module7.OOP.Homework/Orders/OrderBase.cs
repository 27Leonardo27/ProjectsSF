namespace Module7.OOP.Homework.Orders;

public abstract class OrderBase
{
    public User User { get; protected set; }
    public Product[] Products { get; protected set; }
    public int TotalPrice => GetTotalPrice();

    public OrderBase(User user, params Product[] products)
    {
        Products = products;
        User = user;
    }

    protected virtual int GetTotalPrice()
    {
        var totalPrice = 0;

        foreach (var product in Products)
        {
            totalPrice += product.Price;
        }
        
        return totalPrice;
    }

    public abstract string GetStatus();
    public abstract string GetDeliveryDetails();
}