namespace Solid.OCP.Vehicles;

class Vehicle : IVehicle {
    protected string Color { get; set; }
    protected int Year { get; set; }
    protected double Engine { get; set; }

    public Vehicle(string color, int year, double engine) {
        this.Color = color;
        this.Year = year;
        this.Engine = engine;
    }

    public void StartVehicle() => Console.WriteLine("Ligando os motores");
}