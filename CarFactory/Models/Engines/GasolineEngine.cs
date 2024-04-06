namespace CarFactory.Models.Engines;

public class GasolineEngine : IEngine
{
    public string Name { get; } = "Бензиновый двигаталь";
    public int EngineRPM { get; } = 5000;
}