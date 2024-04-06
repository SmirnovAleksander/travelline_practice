namespace CarFactory.Models.Shapes;

public interface IShape : IModel
{
    double AirResistanceCoefficient { get; }
    double SCar { get; }
}