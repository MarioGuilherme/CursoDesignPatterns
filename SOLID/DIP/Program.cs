using DIP.Payments;

namespace DIP;

internal class Program {
    static void Main(string[] args) {
        Environment.SetEnvironmentVariable("DB", "MONGODB");

        PaymentProcess paymentProcess = new();
        paymentProcess.Pay("ABC123");
        Console.ReadLine();
    }
}