namespace Strategy.Domain;

public static class DataReader
{
    public static IEnumerable<Customer> GetCustomers()
    {
        return new List<Customer>()
        {
            new Customer()
            {
                Id = 1,
                Name = "Mohamed Alaa saad",
                CustomerCategory = CustomerCategory.Gold
            },
            new Customer()
            {
                Id = 2,
                Name = "Mahmoud Alaa Saad",
                CustomerCategory = CustomerCategory.Silver
            },
            new Customer()
            {
                Id = 3,
                Name = "Alaa Saad",
                CustomerCategory = CustomerCategory.New
            }
        };
    }
}