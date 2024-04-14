namespace ChainOfResponsability.Middlewares;

public abstract class Middleware {
    private Middleware _next;

    public Middleware LinkWith(Middleware next) {
        this._next = next;
        return next;
    }

    public abstract bool Check(string email, string password);

    protected bool CheckNext(string email, string password) {
        if (this._next is null) return true;
        return this._next.Check(email, password);
    }
}