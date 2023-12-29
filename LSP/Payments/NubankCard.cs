namespace LSP.Payments;

abstract class NubankCard : IPaymentInstrument {
    public void CollectPayment() {
        Console.WriteLine("Pagamento realizado!");
    }

    public abstract void Validate();
}