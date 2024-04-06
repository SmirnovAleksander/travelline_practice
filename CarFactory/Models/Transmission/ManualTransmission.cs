namespace CarFactory.Models.Transmission;

public class ManualTransmission : ITransmission
{
    public string Name { get; } = "Механичская коробка передач";
    public double Efficiency { get; } = 0.95d;
}