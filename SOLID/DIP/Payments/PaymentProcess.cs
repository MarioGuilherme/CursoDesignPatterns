using DIP.Factory;
using DIP.Model;

namespace DIP.Payments;

class PaymentProcess {
    public void Pay(string id) {
        IDbProduct product = DbProductFactory.Create();
        string productData = product.GetProductById(id);
        Console.WriteLine(productData);
    }
}