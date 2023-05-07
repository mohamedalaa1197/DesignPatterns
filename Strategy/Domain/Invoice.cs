using System.Runtime;

namespace Strategy.Domain;

public class Invoice
{
    public Customer Customer { get; set; }
    public IEnumerable<Item> Items { get; set; }
    public decimal TotalPrice => Items.Sum(x => x.UnitPrice * x.Quantity);
    public decimal DiscountPrecentage { get; set; }
}