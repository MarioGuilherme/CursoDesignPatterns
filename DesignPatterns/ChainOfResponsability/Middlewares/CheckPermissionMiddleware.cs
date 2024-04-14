using ChainOfResponsability.Servers;

namespace ChainOfResponsability.Middlewares;

// Aqui ele só retorna true ou next, ou seja, sempre irá passar sem quebrar a execução
public class CheckPermissionMiddleware : Middleware {
    public override bool Check(string email, string password) {
        if (email.Equals("master@hcode.com.br"))
            Console.WriteLine("Seja bem-vindo administrador.");
        else
            Console.WriteLine("Seja bem-vindo");
        return this.CheckNext(email, password);
    }
}