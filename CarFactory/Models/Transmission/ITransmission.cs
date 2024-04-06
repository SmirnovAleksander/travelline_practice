namespace CarFactory.Models.Transmission;

public interface ITransmission : IModel
{
    double Efficiency { get; }
}