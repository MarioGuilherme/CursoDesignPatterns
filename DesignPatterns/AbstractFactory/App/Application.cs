using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.App;

public class Application(ITransportFactory factory) {
    private readonly IAircraft _aircraft = factory.CreateTransportAircraft();
    private readonly ILandVehicle _landVehicle = factory.CreateTransportLandVehicle();

    public void StartRoute() {
        this._landVehicle.StartRoute();
        this._aircraft.StartRoute();
    }
}