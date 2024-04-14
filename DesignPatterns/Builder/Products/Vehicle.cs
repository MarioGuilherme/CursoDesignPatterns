using Builder.Components;

namespace Builder.Products;

public class Vehicle {
    private VehicleType _vehicleType;
    private int _seats;
    private Engine _engine;
    private Transmission _transmission;
    private AirBag _airBag;

    public VehicleType VehicleType { get; set; }
    public int Seats { get; set; }
    public Engine Engine { get; set; }
    public Transmission Transmission { get; set; }
    public AirBag AirBag { get; set; }
}