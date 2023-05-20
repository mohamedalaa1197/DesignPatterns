using SalesSystem.Payments.Abstraction;

namespace Strategy.PaymentMethods;

public class VisaPaymentMethod : IPaymentMethod
{
    public Payment Charge(int customerId, decimal chargedAmount)
    {
        return new Payment()
        {
            CustomerId = customerId,
            ChargedAmount = chargedAmount * 1.05m,
            ReferenceNumber = Guid.NewGuid()
        };
    }
}