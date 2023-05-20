using SalesSystem.Payments.Abstraction;

namespace Strategy.PaymentMethods;

public class PaypalPaymentMethod : IPaymentMethod
{
    public Payment Charge(int customerId, decimal chargedAmount)
    {
        var commission = chargedAmount < 10000 ? chargedAmount * 0.02m : 0;
        return new Payment()
        {
            CustomerId = customerId,
            ChargedAmount = chargedAmount + commission,
            ReferenceNumber = Guid.NewGuid()
        };
    }
}