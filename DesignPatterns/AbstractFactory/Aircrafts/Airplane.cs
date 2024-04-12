﻿namespace AbstractFactory.Aircrafts;

public class Airplane : IAircraft {
    public void CheckWind() => Console.WriteLine("Verificando os ventos, ventos a 25km, ventos ok!");
    public void GetCargo() => Console.WriteLine("Passageiros à bordo, voô autorizado!");
    public void StartRoute() {
        this.CheckWind();
        this.GetCargo();
        Console.WriteLine("Iniciando decolagem...");
    }
}