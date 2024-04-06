namespace CarFactory.Models.Shapes;

public class SedanShape : IShape
{
    public string Name { get; } = "Седан";
    public double AirResistanceCoefficient { get; } = 0.25d;
    public double SCar { get; } = 2.2d;
}