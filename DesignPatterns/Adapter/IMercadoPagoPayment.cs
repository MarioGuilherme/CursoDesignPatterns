namespace Adapter;

public interface IMercadoPagoPayment {
    Token AuthToken();
    void MercadoPagoPayment();
    void MercadoPagoReceive();
}