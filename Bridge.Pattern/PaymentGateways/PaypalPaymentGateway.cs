namespace Bridge.Pattern.PaymentGateways;

public class PaypalPaymentGateway : IPaymentGateway
{
    public void Charge(decimal amount)
    {
        Console.WriteLine($"[PaypalPaymentGateway: Charge] - {amount}");
    }
}