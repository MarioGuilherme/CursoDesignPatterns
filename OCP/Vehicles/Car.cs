namespace Solid.OCP.Vehicles;

class Car : Vehicle {
    private int _seats { get; set; }
    private int _doors { get; set; }

    public Car(string color, int year, double engine, int seats, int doors) : base(color, year, engine) {
        this._seats = seats;
        this._doors = doors;
        this.ConfigureCar();
    }

    public void ConfigureCar() {
        Console.WriteLine($"Criando um carro {this.Color}, {this.Year}, {this.Engine}, {this._doors} portas e {this._seats} assentos");
        this.StartVehicle();
    }
}