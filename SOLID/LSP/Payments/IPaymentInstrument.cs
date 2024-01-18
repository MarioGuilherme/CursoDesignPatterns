namespace LSP.Payments;

interface IPaymentInstrument {
    void Validate();
    void CollectPayment();
}