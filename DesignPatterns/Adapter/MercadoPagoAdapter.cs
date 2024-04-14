namespace Adapter;

public class MercadoPagoAdapter : IPayPalPayment {
    private readonly MercadoPago _mercadoPago;

    public MercadoPagoAdapter(MercadoPago mercadoPago) {
        this._mercadoPago = mercadoPago;
        Console.WriteLine("Realizando adaptação de MercadoPago para Paypal");
    }

    public Token AuthToken() => this._mercadoPago.AuthToken();

    public void PayPalPayment() => this._mercadoPago.MercadoPagoPayment();

    public void PayPalReceive() => this._mercadoPago.MercadoPagoReceive();
}