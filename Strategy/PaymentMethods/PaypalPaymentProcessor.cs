using SalesSystem.Payments.Abstraction;

namespace Strategy.PaymentMethods;

public class PaypalPaymentProcessor : PaymentProcessor
{
    protected override IPaymentMethod CreatePaymentMethod()
    {
        return new PaypalPaymentMethod();
    }
}