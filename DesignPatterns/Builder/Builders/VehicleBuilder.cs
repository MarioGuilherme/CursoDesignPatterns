using Builder.Components;
using Builder.Products;

namespace Builder.Builders;

public class VehicleBuilder : IBuilder {
    private Vehicle _vehicle = new();

    public Vehicle GetVehicle() {
        Vehicle result = this._vehicle;
        this.Reset();
        return result;
    }

    public void Reset() => this._vehicle = new();

    public void SetEngine(Engine engine) => this._vehicle.Engine = engine;

    public void SetSeats(int seats) => this._vehicle.Seats = seats;

    public void SetTransmission(Transmission transmission) => this._vehicle.Transmission = transmission;

    public void SetVehicleType(VehicleType vehicleType) => this._vehicle.VehicleType = vehicleType;

    public void SetAirBag(AirBag airBag) => this._vehicle.AirBag = airBag;
}