namespace Solid.OCP.Vehicles;

class Motorcycle : Vehicle {
    public Motorcycle(string color, int year, double engine) : base(color, year, engine) => this.ConfigureMotorcycle();

    public void ConfigureMotorcycle() {
        Console.WriteLine($"Criando uma moto {this.Color}, {this.Year}, {this.Engine} cilindradas");
        this.StartVehicle();
    }
}