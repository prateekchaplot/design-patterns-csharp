namespace Bridge.Pattern;

public interface IPaymentGateway
{
    void Charge(decimal amount);
}