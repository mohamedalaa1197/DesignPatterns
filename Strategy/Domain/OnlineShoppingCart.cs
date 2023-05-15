namespace Strategy.Domain;

public class OnlineShoppingCart : ShoppingCart
{
    /// <summary>
    /// this is the template method, its Implementation will vary based on the children this class will have  
    /// </summary>
    /// <param name="invoice"></param>
    public override void ApplyDiscount(Invoice invoice)
    {
        if (invoice.TotalPrice >= 10000)
            invoice.DiscountPrecentage = 0.05m;
    }
}