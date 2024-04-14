namespace Bridge.Platforms;

public class DLive : IPlatform {
    public DLive() {
        this.ConfigureRMTP();
        Console.WriteLine("DLive: Transmissão iniciada");
    }

    public void AuthToken() {
        Console.WriteLine("DLive: Autorizando aplicação");
    }

    public void ConfigureRMTP() {
        this.AuthToken();
        Console.WriteLine("DLive: Configurando servidor RMTP");
    }
}