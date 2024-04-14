using Adapter;

//PayPal payment = new();
//Payonner payment = new();

//IPayPalPayment payment = new PayonnerAdapter(new Payonner());
IPayPalPayment payment = new MercadoPagoAdapter(new MercadoPago());
payment.PayPalPayment();
payment.PayPalReceive();

//payment.SendPayment();
//payment.ReceivePayment();

Console.ReadKey();