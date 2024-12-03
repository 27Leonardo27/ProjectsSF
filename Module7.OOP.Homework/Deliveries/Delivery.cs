namespace Module7.OOP.Homework.Deliveries;

public abstract class Delivery
{
    public string Address { get; protected set; }

    public abstract string GetDetails();
}