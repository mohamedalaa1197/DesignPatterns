namespace Strategy.DiscountStategy;

public class SilverDiscountStrategy : ICustomerDiscountStrategy
{
    public decimal CalculateDiscount(decimal totalPrice)
    {
        return (decimal)(totalPrice >= 10000 ? 0.05 : 0);
    }
}