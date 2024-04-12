using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories;

public class UberTransport : ITransportFactory {
    public IAircraft CreateTransportAircraft() => new Airplane();
    public ILandVehicle CreateTransportLandVehicle() => new Car();
}