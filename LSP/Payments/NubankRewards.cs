namespace LSP.Payments;

class NubankRewards : IPaymentInstrument {
    public void CollectPayment() {
        Console.WriteLine("Pagamento realizado!");
        Console.WriteLine("Pontua��o creditada realizado!");
    }

    public void Validate() {
        Console.WriteLine("Limite OK, Rewards OK!");
    }
}