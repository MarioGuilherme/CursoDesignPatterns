using ChainOfResponsability.Servers;

namespace ChainOfResponsability.Middlewares;

public class CheckWeakPasswordMiddleware : Middleware {
    public override bool Check(string email, string password) {
        if (password.Equals("123456"))
            Console.WriteLine("Por favor, esta senha é muito fraca, sugerimos que realiza a alteração da mesma!");
        return this.CheckNext(email, password);
    }
}