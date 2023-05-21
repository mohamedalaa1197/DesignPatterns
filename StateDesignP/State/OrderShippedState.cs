namespace OnlineOrders.Domain;

public class OrderShippedState : IOrderState
{
    private readonly Order _order;

    public OrderShippedState(Order order)
    {
        _order = order;
    }

    public void Confirm()
    {
        throw new NotImplementedException();
    }

    public void Cancel()
    {
        throw new NotImplementedException();
    }

    public void Process()
    {
        throw new NotImplementedException();
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
        _order.State = new OrderReturnedState(_order);
    }

    public void Draft()
    {
        throw new NotImplementedException();
    }
}