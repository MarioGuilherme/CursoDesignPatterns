namespace FactoryMethod.Vehicles;

public class Bike : IVehicle {
	public void GetCargo() {
		Console.WriteLine("Já pegamos a comida!");
	}

	public void StartRoute() {
		Console.WriteLine("Iniciando o delivery.");
		this.GetCargo();
	}
}