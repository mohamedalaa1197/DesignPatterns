namespace Adapter.Domain;

public class EmplyeesData
{
    public IEnumerable<Employee> GetEmployees()
    {
        return new List<Employee>()
        {
            new Employee()
            {
                FullName = "Mohamed Alaa Saad",
                PayItems = new List<PayItem>()
                {
                    new PayItem() { Name = "Basic Salary", Value = 3000m },
                    new PayItem() { Name = "Transportation", Value = 1000m },
                    new PayItem() { Name = "Medical Insurance", Value = -100m },
                }
            },
            new Employee()
            {
                FullName = "Mahmoud Alaa Saad",
                PayItems = new List<PayItem>()
                {
                    new PayItem() { Name = "Basic Salary", Value = 3000m },
                    new PayItem() { Name = "Transportation", Value = 1000m },
                    new PayItem() { Name = "Medical Insurance", Value = -100m },
                }
            }
        };
    }
}