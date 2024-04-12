namespace AbstractFactory.LandVehicles;

public class Car : ILandVehicle {
    public void GetCargo() => Console.WriteLine("Pegamos os passageiros, estamos prontos");
    public void StartRoute() {
        this.GetCargo();
        Console.WriteLine("Iniciando o trajeto");
    }
}