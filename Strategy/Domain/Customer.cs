namespace Strategy.Domain;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public CustomerCategory CustomerCategory { get; set; }
}

public enum CustomerCategory
{
    New,
    Silver,
    Gold
}