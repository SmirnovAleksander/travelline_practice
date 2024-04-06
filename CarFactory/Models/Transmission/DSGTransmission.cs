namespace CarFactory.Models.Transmission;

public class DSGTransmission : ITransmission
{
    public string Name { get; } = "Direct-shift gearbox(Коробка передач с прямым переключением)";
    public double Efficiency { get; } = 0.9d;
}