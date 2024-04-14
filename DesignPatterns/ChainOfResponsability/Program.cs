using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;

Server _server;

void Init() {
    _server = new();
    _server.RegisterUser("master@hcode.com.br", "123456");
    _server.RegisterUser("mario@hcode.com.br", "456456456456");

    Middleware middleware = new CheckUserMiddleware(_server);

    middleware.LinkWith(new CheckWeakPasswordMiddleware());
    middleware.LinkWith(new CheckPermissionMiddleware());

    _server.SetMiddlware(middleware);
}

Init();

bool isDone;

do {
    Console.WriteLine("Digite o seu e-mail: ");
    string email = Console.ReadLine() ?? string.Empty;

    Console.WriteLine("Digite a sua senha: ");
    string password = Console.ReadLine() ?? string.Empty;

    isDone = _server.Login(email, password);
} while (!isDone);

Console.ReadLine();
