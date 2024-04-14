namespace Adapter;

public class PayPal : IPayPalPayment {
    private Token _token;

    public Token AuthToken() => new();

    public void PayPalPayment() {
        this._token = this.AuthToken();
        Console.WriteLine("Enviando pagamento com PayPal");
    }

    public void PayPalReceive() {
        this._token = this.AuthToken();
        Console.WriteLine("Recebendo pagamento com PayPal");
    }
}