namespace FactoryMethod.Vehicles;

public class Motorcycle : IVehicle {
	public void GetCargo() {
		Console.WriteLine("Pegamos a encomenda!");
	}

	public void StartRoute() {
		Console.WriteLine("Iniciando a entrega.");
		this.GetCargo();
	}
}