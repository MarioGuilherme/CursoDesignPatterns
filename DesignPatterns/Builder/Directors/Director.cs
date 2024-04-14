using Builder.Builders;
using Builder.Components;

namespace Builder.Directors;

public class Director {
    IBuilder builder;

    public Director(IBuilder builder) {
        this.builder = builder;
    }

    public void ConstructSedan() {
        builder.SetVehicleType(VehicleType.Sedan);
        builder.SetEngine(new(2000));
        builder.SetSeats(5);
        builder.SetTransmission(Transmission.Automatic);
    }

    public void ConstructTruck() {
        builder.SetVehicleType(VehicleType.Truck);
        builder.SetEngine(new(4000));
        builder.SetSeats(2);
        builder.SetTransmission(Transmission.Manual);
    }

    public void ConstructSuv() {
        builder.SetVehicleType(VehicleType.SUV);
        builder.SetEngine(new(2600));
        builder.SetSeats(4);
        builder.SetTransmission(Transmission.AutomaticSequential);
        builder.SetAirBag(new(isDoubleFront: true));
    }
}