namespace Bridge.Platforms;

public class Facebook : IPlatform {
    public Facebook() {
        this.ConfigureRMTP();
        Console.WriteLine("Facebook: Transmissão iniciada");
    }

    public void AuthToken() {
        Console.WriteLine("Facebook: Autorizando aplicação");
    }

    public void ConfigureRMTP() {
        this.AuthToken();
        Console.WriteLine("Facebook: Configurando servidor RMTP");
    }
}