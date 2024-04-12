using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories;

public class LimeTransport : ITransportFactory {
    public IAircraft CreateTransportAircraft() => new Drone();
    public ILandVehicle CreateTransportLandVehicle() => new Scooter();
}