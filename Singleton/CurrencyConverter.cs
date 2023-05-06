namespace DesignPatterns;

public class CurrencyConverter
{
    public IEnumerable<ExchangeRate> _exchangeRates { get; set; }

    private static CurrencyConverter _instance;

    // Adding a lock to solve multi-Concurrency.
    private static readonly object _lock = new object();

    // Usage of making a static property inside a normal class
    // Static Property means it belongs to the class itself not to an instance of this class, So it can be called with the class name itself, not an instance of the class
    // Usage :-
    //  1- Data Sharing :- It is used to share data between all instances of the class, as all instances shares the same static property
    //  2- Memory efficient:- Static Properties are stored only once in the memory itself, regardless of how many instances of the class have been created
    public static CurrencyConverter Instance
    {
        get
        {
            lock (_lock)
            {
                _instance ??= new CurrencyConverter();
            }


            return _instance;
        }
    }

    private CurrencyConverter()
    {
        LoadExchangeRate();
    }

    private void LoadExchangeRate()
    {
        Thread.Sleep(3000);
        _exchangeRates = new[]
        {
            new ExchangeRate("EGP", "USD", 30.90m)
        };
    }

    public decimal Convert(string baseCurrency, string targetCurrency, decimal amout)
    {
        var exchangeRate =
            _exchangeRates.FirstOrDefault(x => x.BaseCurrency == baseCurrency && x.TargetCurrency == targetCurrency);
        if (exchangeRate != null) return amout * exchangeRate.Rate;
        return 0;
    }
}