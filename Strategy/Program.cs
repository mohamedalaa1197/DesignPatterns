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

    var customerDiscountStrategy =
        new CustomerDiscountStrategyFactory().CreateCustomerDiscountStrategy(customer.CustomerCategory);

    var invoiceManager = new InvoiceManager();
    invoiceManager.SetDiscountStrategy(customerDiscountStrategy);
    var invoice = invoiceManager.CreateInvoice(customer, quantity, price);
}