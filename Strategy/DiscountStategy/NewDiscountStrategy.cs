namespace Strategy.DiscountStategy;

public class NewDiscountStrategy : ICustomerDiscountStrategy
{
    public decimal CalculateDiscount(decimal totalPrice)
    {
        return 0;
    }
}