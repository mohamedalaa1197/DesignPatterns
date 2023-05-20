using SalesSystem.Payments.Abstraction;

namespace Strategy.PaymentMethods;

public class VisaPaymentProcessor : PaymentProcessor
{
    protected override IPaymentMethod CreatePaymentMethod()
    {
        return new VisaPaymentMethod();
    }
}