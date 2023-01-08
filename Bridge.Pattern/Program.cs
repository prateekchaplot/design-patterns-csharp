using Bridge.Pattern;
using Bridge.Pattern.PaymentGateways;

IPaymentGateway gateway = new PaypalPaymentGateway();
gateway.Charge(19.99m);
