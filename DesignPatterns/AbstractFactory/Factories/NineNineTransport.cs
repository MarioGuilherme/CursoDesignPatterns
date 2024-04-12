using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories;

public class NineNineTransport : ITransportFactory {
    public IAircraft CreateTransportAircraft() => new Helicopter();
    public ILandVehicle CreateTransportLandVehicle() => new Motorcycle();
}