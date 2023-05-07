namespace Adapter.Domain.Adaptor;

public class EmployeeAdaptor
{
    private readonly Employee _employee;
    private readonly IEnumerable<PayItemAdaptor> _payItem;

    public EmployeeAdaptor(Employee employee)
    {
        _employee = employee;
        _payItem = employee.PayItems.Select(x => new PayItemAdaptor(x)).ToList();
    }

    public string FullName => _employee.FullName;
    public IEnumerable<PayItemAdaptor> PayItems => _payItem;
}