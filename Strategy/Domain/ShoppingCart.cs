namespace Strategy.Domain;

/// <summary>
/// this is the parent class, which contain the main methods, but we can't use it, will be base for other entities
/// </summary>
public abstract class ShoppingCart
{
    private List<InvoiceLine> _lines = new List<InvoiceLine>();

    public void AddToCart(int itemId, decimal quantity, decimal unitPrice)
    {
        _lines.Add(new InvoiceLine() { ItemId = itemId, Quantity = quantity, UnitPrice = unitPrice });
    }

    public void Checkout(Customer customer)
    {
        var invoice = new Invoice()
        {
            Customer = customer,
            InvoiceLines = _lines,
        };

        ApplyTaxes(invoice);
        ApplyDiscount(invoice);
        ProcessPayment(invoice);
    }


    private void ApplyTaxes(Invoice invoice)
    {
        invoice.Tax = invoice.TotalPrice * 0.15m;
    }

    private void ProcessPayment(Invoice invoice)
    {
        Console.WriteLine("We have finished your payment");
    }

    /// <summary>
    /// this is the template method, its Implementation will vary based on the children this class will have  
    /// </summary>
    /// <param name="invoice"></param>
    public abstract void ApplyDiscount(Invoice invoice);
}