// See https://aka.ms/new-console-template for more information

using DesignPatterns;

Console.WriteLine("Hello, World!");
while (true)
{
    Console.WriteLine("Enter base Currency");
    var baseCurrency = Console.ReadLine();
    Console.WriteLine("Enter target currency");
    var targetCurrency = Console.ReadLine();
    Console.WriteLine("Enter target Amount");
    var amount = decimal.Parse(Console.ReadLine() ?? string.Empty);
    // var currencyConvertor = new CurrencyConverter();
    Console.WriteLine(CurrencyConverter.Instance.Convert(baseCurrency, targetCurrency, amount));
}