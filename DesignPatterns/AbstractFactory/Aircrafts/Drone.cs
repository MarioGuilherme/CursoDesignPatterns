namespace AbstractFactory.Aircrafts;

public class Drone : IAircraft {
    public void CheckWind() => Console.WriteLine("Ventos calmos, ventos ok!");
    public void GetCargo() => Console.WriteLine("Carga acoplada");
    public void StartRoute() {
        this.CheckWind();
        this.GetCargo();
        Console.WriteLine("Iniciando a decolagem e trajeto");
    }
}