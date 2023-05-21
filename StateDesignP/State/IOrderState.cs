namespace OnlineOrders.Domain;

public interface IOrderState
{
    void Confirm();
    void Cancel();
    void Process();
    void Ship();
    void Deliver();
    void Return();
    void Draft();
}