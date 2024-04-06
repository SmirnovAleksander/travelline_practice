namespace CarFactory.Models.Engines;

public class ElectricEngine : IEngine
{
    public string Name { get; } = "Электрический двигатель";
    public int EngineRPM { get; } = 10000;
}