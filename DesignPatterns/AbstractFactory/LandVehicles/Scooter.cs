namespace AbstractFactory.LandVehicles;

public class Scooter : ILandVehicle {
    public void GetCargo() => Console.WriteLine("Encomenda na mochila");
    public void StartRoute() {
        this.GetCargo();
        Console.WriteLine("Iniciando a entrega via patinete");
    }
}