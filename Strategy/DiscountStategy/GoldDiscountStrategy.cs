namespace Strategy.DiscountStategy;

public class GoldDiscountStrategy : ICustomerDiscountStrategy
{
    public decimal CalculateDiscount(decimal totalPrice)
    {
        return (decimal)(totalPrice >= 10000 ? 0.1 : 0);
    }
}