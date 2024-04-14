using Builder.Builders;
using Builder.Directors;
using Builder.Products;
using System.Text.Json;
using System.Text.Json.Serialization;

VehicleBuilder builder = new();
Director director = new(builder);

director.ConstructSedan();
Vehicle sedan = builder.GetVehicle();

Console.WriteLine($"Criado um veículo do tipo: {sedan.VehicleType}");
Console.WriteLine(JsonSerializer.Serialize(sedan));

director.ConstructTruck();
Vehicle truck = builder.GetVehicle();

Console.WriteLine($"Criado um veículo do tipo: {truck.VehicleType}");
Console.WriteLine(JsonSerializer.Serialize(truck));

director.ConstructSuv();
Vehicle suv = builder.GetVehicle();

Console.WriteLine($"Criado um veículo do tipo: {suv.VehicleType}");
Console.WriteLine(JsonSerializer.Serialize(suv));
