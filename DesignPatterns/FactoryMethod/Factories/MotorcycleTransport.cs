namespace FactoryMethod.Vehicles;

public class MotorcycleTransport : Transport {
	protected override IVehicle CreateTransport() {
		return new Motorcycle();
	}
}