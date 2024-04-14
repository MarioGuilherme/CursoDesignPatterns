namespace Adapter;

public class PayonnerAdapter : IPayPalPayment {
    private readonly Payonner _payonner;

    public PayonnerAdapter(Payonner payonner) {
        this._payonner = payonner;
        Console.WriteLine("Realizando adaptação de Payonner para Paypal");
    }

    public Token AuthToken() => this._payonner.AuthToken();

    public void PayPalPayment() => this._payonner.SendPayment();

    public void PayPalReceive() => this._payonner.ReceivePayment();
}