using System.Runtime;

namespace Strategy.Domain;

public class Invoice
{
    public Customer Customer { get; set; }
    public IEnumerable<InvoiceLine> InvoiceLines { get; set; }
    public decimal TotalPrice => InvoiceLines.Sum(x => x.UnitPrice * x.Quantity);
    public decimal DiscountPrecentage { get; set; }
    public decimal Tax { get; set; }
    public decimal NetPrice => TotalPrice + Tax - TotalPrice * DiscountPrecentage;
}