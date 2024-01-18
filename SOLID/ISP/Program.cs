using Solid.ISP.Vehicles;

namespace Solid.ISP;

class Program {
    static void Main(string[] args) {
        Car car = new("Azul", 2023, 4.0, 2, 2);
        Motorcycle motorcycle = new("Branca", 2024, 600);

        Console.ReadLine();
    }
}