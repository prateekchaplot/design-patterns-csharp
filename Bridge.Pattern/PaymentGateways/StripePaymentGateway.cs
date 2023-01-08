namespace Bridge.Pattern.PaymentGateways;

public class StripePaymentGateway : IPaymentGateway
{
    public void Charge(decimal amount)
    {
        Console.WriteLine($"[StripePaymentGateway: Charge] - {amount}");
    }
}