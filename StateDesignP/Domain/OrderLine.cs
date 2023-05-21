namespace OnlineOrders.Domain;

public class OrderLine
{
    public int ProductId { get; set; }
    public double Quantity { get; set; }
    public double UnitPrice { get; set; }
}