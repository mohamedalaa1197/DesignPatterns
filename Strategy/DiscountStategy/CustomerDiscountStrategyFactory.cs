using Strategy.Domain;

namespace Strategy.DiscountStategy;

public class CustomerDiscountStrategyFactory
{
    /// <summary>
    /// use the Factory method pattern, to move the class creation to a central place, where we can use it always.
    /// </summary>
    public ICustomerDiscountStrategy? CreateCustomerDiscountStrategy(CustomerCategory category)
    {
        switch (category)
        {
            case CustomerCategory.Gold:
                return new GoldDiscountStrategy();
            case CustomerCategory.Silver:
                return new SilverDiscountStrategy();
            case CustomerCategory.New:
                return new NewDiscountStrategy();
        }

        return new NullDiscountStrategy();
    }
}