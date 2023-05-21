namespace OnlineOrders.Domain;

public class OrderDraftState : IOrderState
{
    private readonly Order _order;

    public OrderDraftState(Order order)
    {
        _order = order;
    }

    public void Confirm()
    {
        _order.State = new OrderConfirmedState(_order);
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
        throw new NotImplementedException();
    }

    public void Draft()
    {
        throw new NotImplementedException();
    }
}