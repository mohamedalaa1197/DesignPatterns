namespace Adapter.Domain.Adaptor;

public class PayItemAdaptor
{
    private readonly PayItem _payItem;

    public PayItemAdaptor(PayItem payItem)
    {
        _payItem = payItem;
    }

    public string Name => _payItem.Name;
    public decimal Value => _payItem.Isdeducting ? _payItem.Value * -1 : _payItem.Value;
}