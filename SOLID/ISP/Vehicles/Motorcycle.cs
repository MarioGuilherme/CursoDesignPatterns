namespace Solid.ISP.Vehicles;

class Motorcycle : IVehicleMotorcycle {
    private string _color { get; set; }
    private int _year { get; set; }
    private double _engine { get; set; }

    public Motorcycle(string color, int year, double engine) {
        this.ConfigureMotorcycle(color, year, engine);
    }

    public void ConfigureMotorcycle(string color, int year, double engine) {
        this._color = color;
        this._year = year;
        this._engine = engine;
        Console.WriteLine($"Criando uma moto ano {this._year}, {this._engine} cilindradas e da cor {this._color}.");
        this.StartVehicle();
    }

    public void StartVehicle() => Console.WriteLine("Ligando os motores");
}