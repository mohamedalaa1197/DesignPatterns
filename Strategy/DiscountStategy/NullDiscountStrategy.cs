namespace Strategy.DiscountStategy;

public class NullDiscountStrategy : ICustomerDiscountStrategy
{
    /// <summary>
    /// Null Object Pattern, to return an empty object, which doesn't do any action in case of Null, To avoid the null checks.
    /// </summary>
    /// <param name="totalPrice"></param>
    /// <returns></returns>
    public decimal CalculateDiscount(decimal totalPrice)
    {
        return 0;
    }
}