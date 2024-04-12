using AbstractFactory.App;
using AbstractFactory.Factories;

namespace AbstractFactory;

public class Program {
    public static Application ConfigureApplication() {
        ITransportFactory transportFactory;
        string company = "Lime";

        if (company == "Uber") {
            transportFactory = new UberTransport();
        } else if (company == "Lime") {
            transportFactory = new LimeTransport();
        } else {
            transportFactory = new NineNineTransport();
        }

        return new(transportFactory);
    }

    public static void Main(string[] args) {
        Application app = ConfigureApplication();
        app.StartRoute();
    }
}