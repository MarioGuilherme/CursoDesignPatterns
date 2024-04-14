using ChainOfResponsability.Servers;

namespace ChainOfResponsability.Middlewares;

public class CheckUserMiddleware(Server server) : Middleware {
    private readonly Server _server = server;

    public override bool Check(string email, string password) {
        if (!this._server.HasEmail(email)) {
            Console.WriteLine("E-mail inválido");
            return false;
        }

        if (!this._server.IsValidPassword(email, password)) {
            Console.WriteLine("E-mail e/ou senha inválidos");
            return false;
        }

        return this.CheckNext(email, password);
    }
}