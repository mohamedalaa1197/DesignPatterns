namespace OnlineOrders.Domain;

public class Order
{
    public Order()
    {
        State = new OrderDraftState(this);
    }

    public IOrderState State { get; internal set; }
    public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();


    public void Confirm()
    {
        State.Confirm();
    }

    public void Cancel()
    {
        State.Cancel();
    }

    public void Ship()
    {
        State.Ship();
    }

    public void Return()
    {
        State.Return();
    }

    public void Draft()
    {
        State.Draft();
    }

    public void Deliver()
    {
        State.Deliver();
    }

    public void Process()
    {
        State.Process();
    }
}