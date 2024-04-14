namespace Bridge.Platforms;
public class YouTube : IPlatform {
    public YouTube() {
        this.ConfigureRMTP();
        Console.WriteLine("Youtube: Transmissão iniciada");
    }

    public void AuthToken() {
        Console.WriteLine("Youtube: Autorizando aplicação");
    }

    public void ConfigureRMTP() {
        this.AuthToken();
        Console.WriteLine("Youtube: Configurando servidor RMTP");
    }
}