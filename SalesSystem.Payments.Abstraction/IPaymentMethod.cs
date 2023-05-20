namespace SalesSystem.Payments.Abstraction;

public interface IPaymentMethod
{
    Payment Charge(int customerId, decimal chargedAmount);
}