namespace OnlineOrders.Domain;

public enum OrderState
{
    Draft,
    Confirmed,
    Canceled,
    UnderProcessing,
    Shipped,
    Delivered,
    Returned
}