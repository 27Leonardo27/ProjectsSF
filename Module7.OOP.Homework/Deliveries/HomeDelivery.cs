namespace Module7.OOP.Homework.Deliveries;

public class HomeDelivery : Delivery
{
    public HomeDelivery(string address)
    {
        Address = address;
    }

    public override string GetDetails()
    {
        return $"На дом по адресу: {Address}";
    }
}