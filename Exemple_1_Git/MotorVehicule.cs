using System;
public class Car : Vehicle  {
    public double FuelRemaining { get; set; }
    public double TankSize { get; set; }
    public double MPG { get; private set; }

    public double Refuel()
    {
        var whatsMissing = TankSize - FuelRemaining;
        FuelRemaining = TankSize;
        return whatsMissing;
        
    }

    public override string Indicate (bool turnLeft)
    {
        return turnLeft ? "Flashing Left indicator" : "Flashing Right indicator";
    }

}
