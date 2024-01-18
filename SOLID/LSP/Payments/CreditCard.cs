namespace LSP.Payments;

class CreditCard : NubankCard {
    public override void Validate() {
        Console.WriteLine("Validando o limite...");
        Console.WriteLine("Limite OK!");
    }
}