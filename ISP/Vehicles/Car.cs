namespace Solid.ISP.Vehicles;

class Car : IVehicleCar {
    private string _color { get; set; }
    private int _year { get; set; }
    private double _engine { get; set; }
    private int _seats { get; set; }
    private int _doors { get; set; }

    public Car(string color, int year, double engine, int seats, int doors) {
        this.ConfigureCar(color, year, engine, seats, doors);
    }

    public void ConfigureCar(string color, int year, double engine, int seats, int doors) {
        this._color = color;
        this._year = year;
        this._engine = engine;
        this._seats = seats;
        this._doors = doors;
        Console.WriteLine($"Criando um carro ano {this._year}, motor {this._engine} da cor {this._color}.");
        this.StartVehicle();
    }

    public void StartVehicle() => Console.WriteLine("Ligando os motores");
}