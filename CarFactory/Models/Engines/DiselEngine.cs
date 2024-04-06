namespace CarFactory.Models.Engines;

public class DiselEngine : IEngine
{
    public string Name { get; } = "Дизельный двигатель";
    public int EngineRPM { get; } = 3000;
}