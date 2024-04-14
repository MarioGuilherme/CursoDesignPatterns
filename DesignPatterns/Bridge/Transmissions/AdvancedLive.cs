using Bridge.Platforms;

namespace Bridge.Transmissions;

public class AdvancedLive(IPlatform platform) : Live(platform) {
    public void Subtitle() {
        Console.WriteLine("Legendas ativadas na live");
    }

    public void Comments() {
        Console.WriteLine("Comentários liberados na live");
    }

    public void Record() {
        Console.WriteLine("Gravação da live iniciada.");
    }
}