using Module7.OOP.Homework.Deliveries;

namespace Module7.OOP.Homework.Orders;

public enum OrderStatus
{
    InProcessing,
    Delivering,
    Pending,
    Delivered,
    Canceled
}

public class Order<TDelivery> : OrderBase
    where TDelivery : Delivery
{
    protected TDelivery Delivery { get; }

    private OrderStatus status;
    
    public Order(User user, TDelivery delivery, params Product[] products)
        : base(user, products)
    {
        Delivery = delivery;
        status = OrderStatus.InProcessing;
    }

    public override string GetDeliveryDetails()
    {
        return Delivery.GetDetails();
    }

    public override string GetStatus()
    {
        switch (status)
        {
            case OrderStatus.InProcessing:
                return "В Обработке";
            case OrderStatus.Delivering:
                return "Доставка";
            case OrderStatus.Pending:
                return "Ожидает вручения";
            case OrderStatus.Delivered:
                return "Доставлен";
            case OrderStatus.Canceled:
                return "Отменен";
            default:
                return "Неизвестный статус заказа";
        }
    }

    public void SetStatus(OrderStatus status)
    {
        this.status = status;
    }
}