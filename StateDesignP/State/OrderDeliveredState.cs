namespace OnlineOrders.Domain;

public class OrderDeliveredState : IOrderState
{
    private readonly Order _order;

    public OrderDeliveredState(Order order)
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