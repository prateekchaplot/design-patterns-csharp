namespace Bridge.Pattern.PaymentGateways;

public class SquarePaymentGateway : IPaymentGateway
{
    public void Charge(decimal amount)
    {
        Console.WriteLine($"[SquarePaymentGateway: Charge] - {amount}");
    }
}