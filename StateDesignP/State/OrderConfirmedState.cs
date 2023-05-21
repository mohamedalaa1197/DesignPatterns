namespace OnlineOrders.Domain;

public class OrderConfirmedState : IOrderState
{
    private readonly Order _order;

    public OrderConfirmedState(Order order)
    {
        _order = order;
    }

    public void Confirm()
    {
        throw new NotImplementedException();
    }

    public void Cancel()
    {
        _order.State = new OrderCanceledState(_order);
    }

    public void Process()
    {
        _order.State = new OrderProcessedState(_order);
    }

    public void Ship()
    {
        throw new NotImplementedException();
    }

    public void Deliver()
    {
        throw new NotImplementedException();
    }

    public void Return()
    {
        throw new NotImplementedException();
    }

    public void Draft()
    {
        throw new NotImplementedException();
    }
}