namespace Bridge.Platforms;
public class TwitchTV : IPlatform {
    public TwitchTV() {
        this.ConfigureRMTP();
        Console.WriteLine("TwitchTV: Transmissão iniciada");
    }

    public void AuthToken() {
        Console.WriteLine("TwitchTV: Autorizando aplicação");
    }

    public void ConfigureRMTP() {
        this.AuthToken();
        Console.WriteLine("TwitchTV: Configurando servidor RMTP");
    }
}