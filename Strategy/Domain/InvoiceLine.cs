namespace Strategy.Domain;

public class InvoiceLine
{
    public int ItemId { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Quantity { get; set; }
}