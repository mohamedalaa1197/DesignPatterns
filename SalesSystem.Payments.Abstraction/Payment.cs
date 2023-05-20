namespace SalesSystem.Payments.Abstraction;

public class Payment
{
    public int CustomerId { get; set; }
    public decimal ChargedAmount { get; set; }
    public Guid ReferenceNumber { get; set; }
}