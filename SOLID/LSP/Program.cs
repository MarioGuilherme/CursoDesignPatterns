using LSP.Payments;

namespace Solid.LSP;

class Program {
    static void Main(string[] args) {
        //CreditCard card = new();
        //DebitCard card = new();
        NubankRewards card = new();

        card.Validate();
        card.CollectPayment();

        Console.ReadLine();
    }
}