namespace FactoryMethod.Vehicles;

public class CarTransport : Transport {
	protected override IVehicle CreateTransport() => new Car();
}