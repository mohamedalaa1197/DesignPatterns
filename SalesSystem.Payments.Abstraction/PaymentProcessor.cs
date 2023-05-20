namespace SalesSystem.Payments.Abstraction;

public abstract class PaymentProcessor
{
    public Payment ProcessPayment(int customerId, decimal chargedAmount)
    {
        var paymentMethod = CreatePaymentMethod();
        var payment = paymentMethod.Charge(customerId, chargedAmount);

        return payment;
    }

    /// <summary>
    /// This is the Factory Method, which its Implementation will be on the client side.
    /// </summary>
    /// <returns></returns>
    protected abstract IPaymentMethod CreatePaymentMethod();
}