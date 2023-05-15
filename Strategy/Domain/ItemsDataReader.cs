namespace Strategy.Domain;

public static class ItemsDataReader
{
    public static IEnumerable<Item> GetItems()
    {
        return new List<Item>()
        {
            new Item() { Id = 1, Name = "Keyboard", UnitPrice = 1000 },
            new Item() { Id = 1, Name = "Mouse", UnitPrice = 2000 },
            new Item() { Id = 1, Name = "LCD", UnitPrice = 10000 }
        };
    }
}