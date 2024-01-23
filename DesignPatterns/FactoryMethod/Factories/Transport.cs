namespace FactoryMethod.Vehicles;

public abstract class Transport {
	public void StartTransport() {
		IVehicle vehicle = this.CreateTransport();
		vehicle.StartRoute();
	}

	protected abstract IVehicle CreateTransport();
}