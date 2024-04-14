using ChainOfResponsability.Middlewares;

namespace ChainOfResponsability.Servers;

public class Server {
    private Dictionary<string, string> _users = [];
    private Middleware _middleware;

    public void SetMiddlware(Middleware middleware) {
        this._middleware = middleware;
    }

    public bool Login(string email, string password) {
        if (this._middleware.Check(email, password)) {
            Console.WriteLine("Usuário autorizado com sucesso!");
            Console.WriteLine("Seja bem vindo!");
            return true;
        }
        return false;
    }

    public void RegisterUser(string email, string password) {
        this._users[email] = password;
    }

    public bool HasEmail(string email) {
        return this._users.ContainsKey(email);
    }

    public bool IsValidPassword(string email, string password) {
        _users.TryGetValue(email, out string? value);
        return password == value;
    }
}