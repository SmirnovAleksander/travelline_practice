namespace CarFactory.Models.Transmission;

public class AutomaticTransmission : ITransmission
{
    public string Name { get; } = "Автоматическая коробка передач";
    public double Efficiency { get; } = 0.8d;
}