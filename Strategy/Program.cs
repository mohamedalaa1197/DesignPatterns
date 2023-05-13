// See https://aka.ms/new-console-template for more information

// strategy design pattern
//  it is used when we want to have different behaviour during run based on a specific conditions
// like the case that we had currently 

using Strategy.DiscountStategy;
using Strategy.Domain;

var customers = DataReader.GetCustomers();

while (true)
{
    Console.WriteLine("Enter customer Id [1],[2],[3]");
    var customerId = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter Item Quantity");
    var quantity = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Enter Item Price");
    var price = decimal.Parse(Console.ReadLine());

    var customer = customers.FirstOrDefault(x => x.Id == customerId);


    #region Old way without using the factory pattern

    // if (customer.CustomerCategory == CustomerCategory.Gold)
    // {
    //     customerDiscountStrategy = new GoldDiscountStrategy();
    // }
    // else if (customer.CustomerCategory == CustomerCategory.Silver)
    // {
    //     customerDiscountStrategy = new SilverDiscountStrategy();
    // }
    // else if (customer.CustomerCategory == CustomerCategory.New)
    // {
    //     customerDiscountStrategy = new NewDiscountStrategy();
    // }

    #endregion

    #region when using the Factory pattern

    ICustomerDiscountStrategy customerDiscountStrategy =
        new CustomerDiscountStrategyFactory().CreateCustomerDiscountStrategy(customer.CustomerCategory);

    #endregion

    var invoiceManager = new InvoiceManager();
    invoiceManager.SetDiscountStrategy(customerDiscountStrategy);
    var invoice = invoiceManager.CreateInvoice(customer, quantity, price);
}