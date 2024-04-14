namespace Adapter;

public class Payonner : IPayonnerPayment {
    private Token _token;

    public Token AuthToken() => new();

    public void ReceivePayment() {
        this._token = this.AuthToken();
        Console.WriteLine("Recebendo pagamento com payonner");
    }

    public void SendPayment() {
        this._token = this.AuthToken();
        Console.WriteLine("Enviando pagamento com payonner");
    }
}