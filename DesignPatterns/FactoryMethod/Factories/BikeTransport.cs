namespace FactoryMethod.Vehicles;

public class BikeTransport : Transport {
	protected override IVehicle CreateTransport() {
		return new Bike();
	}
}