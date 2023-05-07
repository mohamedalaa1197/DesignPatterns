namespace Strategy.DiscountStategy;

public interface ICustomerDiscountStrategy
{
    decimal CalculateDiscount(decimal totalPrice);
}