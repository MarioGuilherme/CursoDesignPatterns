namespace AbstractFactory.LandVehicles;

public class Motorcycle : ILandVehicle {
    public void GetCargo() => Console.WriteLine("Pegamos a encomenda");
    public void StartRoute() {
        this.GetCargo();
        Console.WriteLine("Iniciando a entrega");
    }
}