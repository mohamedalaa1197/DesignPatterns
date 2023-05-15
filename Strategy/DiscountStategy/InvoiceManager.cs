using Strategy.Domain;

namespace Strategy.DiscountStategy;

public class InvoiceManager
{
    private ICustomerDiscountStrategy _customerDiscountStrategy;
    
    public void SetDiscountStrategy(ICustomerDiscountStrategy discountStrategy)
    {
        _customerDiscountStrategy = discountStrategy;
    }


    public Invoice CreateInvoice(Customer customer, decimal quantity, decimal unitPrice)
    {
        var invoice = new Invoice()
        {
            Customer = customer,
            InvoiceLines = new List<InvoiceLine>()
            {
                new InvoiceLine() { Quantity = quantity, UnitPrice = unitPrice }
            }
        };
        invoice.DiscountPrecentage = _customerDiscountStrategy.CalculateDiscount(invoice.TotalPrice);
        return invoice;
    }
}