namespace Solid.OCP.Vehicles;

class Program {
    static void Main(string[] args) {
        TypeVehicle typeVehicle = TypeVehicle.CAR;

        if (typeVehicle == TypeVehicle.CAR) {
            Car car = new(
                color: "Azul",
                year: 2023,
                engine: 2.0,
                doors: 4,
                seats: 5
            );
        } else {
            Motorcycle motorcycle = new(
                color: "Branco",
                year: 2024,
                engine: 250
            );
        }

        Console.ReadLine();
    }
}