namespace AbstractFactory.Aircrafts;

public class Helicopter : IAircraft {
    public void CheckWind() => Console.WriteLine("Verificando vento, vento sudeste, ventos ok!");
    public void GetCargo() => Console.WriteLine("Passageiros ok. Ligando as helices");
    public void StartRoute() {
        this.CheckWind();
        this.GetCargo();
        Console.WriteLine("Iniciando a decolagem");
    }
}