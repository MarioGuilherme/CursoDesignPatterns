namespace Adapter;

public class MercadoPago : IMercadoPagoPayment {
    private Token _token;

    public Token AuthToken() => new();

    public void MercadoPagoPayment() {
        this._token = this.AuthToken();
        Console.WriteLine("Enviando pagamento com MercadoPago");
    }

    public void MercadoPagoReceive() {
        this._token = this.AuthToken();
        Console.WriteLine("Recebendo pagamento com MercadoPago");
    }
}