using Bridge.Platforms;

namespace Bridge.Transmissions;

public class Live(IPlatform platform) : ITransmission {
    protected IPlatform _platform = platform;

    public void Broadcasting() {
        Console.WriteLine($"Iniciando a transmissão na {this._platform}");
    }

    public void Result() {
        Console.WriteLine("**** NO AR ****");
    }
}